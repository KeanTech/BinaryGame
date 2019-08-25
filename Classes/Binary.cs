namespace BinaryGame
{
    class Binary
    {
        public int ToDecimal(int binary)
        {
            int dec = 0, pow = 1, rem;

            while (binary > 0)
            {

                rem = binary % 10;
                dec = dec + rem * pow;
                binary = binary / 10;
                pow = pow * 2;
            }
            
            return dec;
        }
    }
}
