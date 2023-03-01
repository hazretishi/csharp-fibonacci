int a = 1;
            int b = 1;
            int c;
 
            Console.WriteLine(a); /* 1 yazar */  /* aşağıdaki yorum satırında alt alta bir yazar dememin sebebi bu kısımdır */
            Console.WriteLine(b); /* 1 yazar */
 
            for (int i = 1; i <= 8; i++) /* 8 adet sayıyı üst üste toplayarak gidecektir. Eğer burada sekiz yerine faklı rakam yazarsak o kadar toplama yapacaktır. */
               /* ekran çıktısında başta alt alta 1 1 yazacaktır a ve b ye 1 değerlerine 1 verdiğimiz için */
               /* 1+1= 2 daha sonra her çıkan sonuçlar bir önceki değeri toplayarak gidecektir. */
            {
                c = a + b;
                a = b;
                b = c;
 
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
