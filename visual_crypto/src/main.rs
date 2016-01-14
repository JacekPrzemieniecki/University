extern crate bmp;
extern crate rand;
use bmp::{Image, Pixel};
use rand::Rng;
use std::env;

const BLACK: Pixel = Pixel {
    r: 255,
    g: 255,
    b: 255,
};
const WHITE: Pixel = Pixel { r: 0, g: 0, b: 0 };

fn print_usage() {
    println!("Usage:\nvisual_crypto <file_to_encrypt> <output>\nvisual_crypto <file_to_decrypt1> <file_to_decrypt2> <output>");
}

fn generate_random_bmp(x: u32, y: u32) -> Image {
    let mut img = Image::new(x, y);
    let mut rng = rand::thread_rng();

    for y_coord in 0..y {
        for x_coord in 0..x {
            img.set_pixel(x_coord,
                          y_coord,
                          match rng.gen() {
                              true => BLACK,
                              false => WHITE,
                          });
        }
    }
    return img;
}

fn xor_img(img1: &Image, img2: &Image) -> Image {
    let width = img1.get_width();
    let height = img1.get_height();
    let mut result = Image::new(width, height);

    for y_coord in 0..height {
        for x_coord in 0..width {
            let pixel1 = img1.get_pixel(x_coord, y_coord);
            let pixel2 = img2.get_pixel(x_coord, y_coord);
            let color = if pixel1 == pixel2 { BLACK } else { WHITE };
            result.set_pixel(x_coord,
                                y_coord,
                                color)
        }
    }
    return result;
}

fn encrypt(filename: &str, output_file: &str) { 
    let input_img = bmp::open(&filename).unwrap_or_else(|e| {panic!("Failed to open: {}", e)});
    let width = input_img.get_width();
    let height = input_img.get_height();
    let random_img = generate_random_bmp(width, height);

    let out_1_name = "1_".to_string() + output_file;
    let _ = random_img.save(&out_1_name);

    let out_2_name = "2_".to_string() + output_file;
    let out_2_img = xor_img(&input_img, &random_img);

    let _ = out_2_img.save(&out_2_name);
}

fn decrypt(file1: &str, file2: &str, output_file: &str) {
    let in_1_img = bmp::open(file1).unwrap_or_else(|e| {panic!("Failed to open: {}", e)});
    let in_2_img = bmp::open(file2).unwrap_or_else(|e| {panic!("Failed to open: {}", e)});
    let width = in_1_img.get_width();
    let height = in_2_img.get_height();
    if width != in_2_img.get_width() || height != in_2_img.get_height(){
        panic!("Input file dimentions do not match");
    }
    let result = xor_img(&in_1_img, &in_2_img);
    let result_name = output_file;
    let _ = result.save(&result_name);
}

fn main() {
    let arguments: Vec<_> = env::args().collect();
    match arguments.len() {
        3 => encrypt(&arguments[1], &arguments[2]),
        4 => decrypt(&arguments[1], &arguments[2], &arguments[3]),
        _ => print_usage()
    };
}
