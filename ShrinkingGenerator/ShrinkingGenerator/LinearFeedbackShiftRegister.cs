namespace ShrinkingGenerator
{
    struct LinearFeedbackShiftRegister
    {
        uint _state;
        readonly uint _toggleMask;

        public LinearFeedbackShiftRegister(uint initialValue, uint toggleMask)
        {
            _state = initialValue;
            _toggleMask = toggleMask;
        }

        public uint Tick()
        {
            uint result = 0;

            for (int i = 0; i < 32; i++)
            {
                uint outputBit = _state & 1;
                result <<= 1;
                result |= outputBit;
                _state >>= 1;
                if (outputBit != 0)
                {
                    _state ^= _toggleMask;
                }
            }

            return result;
        }
    }
}