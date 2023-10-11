using System;

namespace LeLenhNguyen_2021604114_proj52
{
    class TimUCLN
    {
        private int sothu1, sothu2;

        public int SoThuNhat
        {
            get => sothu1;
            set => sothu1 = value;
        }

        public int SoThuHai
        {
            get => sothu2;
            set => sothu2 = value;
        }
        public TimUCLN(int sothu1, int sothu2)
        {
            this.sothu1 = sothu1;
            this.sothu2 = sothu2;
        }
        public int UCLN()
        {
            int a = Math.Abs(sothu1);
            int b = Math.Abs(sothu2);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
    }
}