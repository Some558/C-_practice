namespace CS29
{
    internal class Counter
    {
        // �A�v���P�[�V�����Ɉ�����ȉ��������������ꍇ��static�ɂ���
        private static int _count = 0;
        // �ÓI���\�b�h
        internal static void Call()
        {
            _count++;
            // _value = 1;

            // var ddd = 0;
            // ddd = 1;
        }

        internal static int GetCount()
        {
            return _count;
        }
    }
}
