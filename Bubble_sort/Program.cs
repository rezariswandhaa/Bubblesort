using System;

    namespace Bubble_sort
{
    class program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //Deklarasi variabel int untuk menerima masukan 
        private int n;

        //fungsi / method untuk menerima masukan 
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpaan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-------------------------");

            // pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
    }
}