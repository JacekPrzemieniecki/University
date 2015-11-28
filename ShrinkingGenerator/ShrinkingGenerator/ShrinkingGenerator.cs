namespace ShrinkingGenerator
{
    class ShrinkingGenerator
    {
        uint _controlRegister;
        uint _feedBuffer;
        int _bufferLen;
        LinearFeedbackShiftRegister _lsfr1;
        LinearFeedbackShiftRegister _lsfr2;

        public ShrinkingGenerator(LinearFeedbackShiftRegister lsfr1, LinearFeedbackShiftRegister lsfr2)
        {
            _lsfr1 = lsfr1;
            _lsfr2 = lsfr2;
        }

        public byte Current { get; private set; }

        public void MoveNext()
        {
            byte nextVal = 0;
            var bitsLeft = 8;

            while (bitsLeft > 0)
            {
                if (_bufferLen == 0)
                {
                    _controlRegister = _lsfr1.Tick();
                    _feedBuffer = _lsfr2.Tick();
                    _bufferLen = 8;
                }

                if ((_controlRegister & 1) != 0)
                {
                    nextVal |= (byte)(_feedBuffer & 1);
                    nextVal <<= 1;
                    bitsLeft--;
                }
                _controlRegister >>= 1;
                _feedBuffer >>= 1;
                _bufferLen--;
            }
            Current = nextVal;
        }
    }
}