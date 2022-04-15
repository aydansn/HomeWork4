using System;

namespace Homework._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            // 1-1000 qeder CUT ederlerin icerisinde reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
            //int sum = 0;
            //int number = 0;
            //for (int i = 2; i <= 1000; i++)
            //{
            //    if (i%2==0)
            //    {
            //        int a = i;
            //        while (a!=0)
            //        {
            //            sum += a % 10;
            //            a /= 10;

            //        }
            //        if (sum==6)
            //        {
            //            number = i;
            //        }

            //    }
            //    sum = 0;

            //}
            //Console.WriteLine($"axtarilan eded = {number}");

            #endregion

            #region Task2
            // 1 - 1000 qeder ederlerin icerisinden ele ededleri cap etki:
            //  hem polindrom olsun,
            //hem ededin reqemleri daxilinde 3 olmasin
            //hem ededin reqemleri cemi 10 dan boyuk olsun

            //for (int i = 1; i < 1000; i++)
            //{
            //   int a = i; int sum1 =0; int b; int sum2 = 0; int eded;
            //    while (a > 0)
            //    {
            //        b = a % 10;
            //        sum1 = (sum1 * 10) + b;
            //        sum2 = sum2 + b;
            //        a = a / 10;

            //    }

            //    if (sum2 > 10 && i == sum1 && i / 100 != 3 &&  i % 10 != 3 && i % 100 / 10 !=3 )
            //    {
            //        eded = i;
            //        Console.WriteLine(eded);
            //    }

            //}

            #endregion


            #region Task3
            //1 - 100000 qeder ederlerin icerisinden ele ededleri cap etki:
            //hem butun reqemleri eyni olsun,
            //hem reqemleri cemi 5 den boyuk olsun
            //hem reqemleri arasinda 5 reqemi olmasin
            //int numb;
            //int sum;
            //int last;
            //bool state;
            //bool succsess;
            //int temp2;

            //int temp;
            //for (int i = 1; i < 100000; i++)
            //{
            //    numb = i;
            //    last = i % 10;
            //    state = false;

            //    while (numb > 0)
            //    {
            //        if (numb % 10 != last)
            //        {
            //            state = true;
            //            break;
            //        }
            //        numb = numb / 10;

            //    }
            //    if (state == false)
            //    {
            //        sum = 0;
            //        temp = i;//temp=11
            //        while (temp > 0)
            //        {
            //            sum = sum + (temp % 10);
            //            temp = temp / 10;

            //        }
            //        if (sum > 5)
            //        {
            //            succsess = false;
            //            temp2 = i;
            //            while (temp2 > 0)
            //            {
            //                if (temp2 % 10 == 5)
            //                {
            //                    state = true;
            //                    break;
            //                }
            //                temp2 = temp2 / 10;

            //            }
            //            if (state == false)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }



            //    }

            //}

            #endregion


            #region Task4
            //1 - 1000 qeder ederlerin icerisinde
            //11 - e bolunub reqemleri cemi 11 - den boyuk olan 11 - ci eded hansidir?
            //int num ;
            //int sum;
            //for (int i = 1; i < 1000; i++)
            //{

            //    if (i % 11 == 0)
            //    {
            //        num = i;
            //        sum = 0;
            //        while (num > 0)
            //        {
            //            sum = sum + (num % 10);
            //            num = num / 10;
            //        }
            //        if (sum > 11)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //}





            #endregion


            #region Task5
            //Her hansi bir eded daxil et.
            //Eger eded polindromdursa o zaman bu ededin evveline ve axirin 1 reqemini artir ve cap et.
            //Eks halda ededin ozunu cap et.polindrom eded:  123321; 12321--guzgu effekti
            //int a = 799;
            //int b = a;
            //int num = 0;
            //int remain;
            //while (a > 0)
            //{
            //    remain = a % 10;
            //    a = a / 10;
            //    num = num * 10 + remain;

            //}
            //if (num == b)
            //{
            //    num = num * 10 + 1;
            //    while (num > 0)
            //    {
            //        remain = num % 10;
            //        num = num / 10;
            //        a = a * 10 + remain;

            //    }
            //    a = a * 10 + 1;
            //    Console.WriteLine($"eded polidromdur: {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"{b} ededi polidrom deyil ");
            //}

            //#endregion

            //#region Task6
            //                Her hansi bir eded daxil et.
            //   Bu ededin daxilinden 5 ve 7 reqemlerini legv et.
            //Neticenin I ve Sonuncu reqemlerini deyishib cap et.
            //   Alinan cavabin icerisinde nece dene tek reqem oldugunu yaz.
            

            //int num = 1234567;
            //int number = 0;
            //int remain;
            //int firstNum;
            //int lastNum;
            //int counter = 0;
            //while (num>0)
            //{
            //    remain = num % 10;
            //    num /= 10;
            //    if (remain % 10 != 5 && remain % 10 != 7)
            //    {
            //        number = number * 10 + remain;
            //    }
            //}
            // firstNum = number % 10;

            //while (number>0)
            //{   remain = number % 10;
            //    number /= 10;
            //    num = num * 10 + remain;
            //}
            // lastNum = num % 10;
            // num /= 10;
            // num = num * 10 + firstNum;
            //while (num>0)
            //{
            //    remain = num % 10;
            //    num/=10;
            //    number = number * 10 + remain;

            //}
            //number /= 10;
            //number = number * 10 + lastNum;
            //while (number> 0)
            //{
            //    remain = number % 10;
            //    number /= 10;
            //    num = num * 10 + remain;

            //}
            //Console.Write($"{num} reqeminde ");
            //while (num>0)
            //{
            //    remain = num % 10;
            //    if (remain%2==1)
            //    {
            //        counter++;
            //    }
            //    num /= 10;
            //}
            //Console.WriteLine($"{counter}eded tek reqem var");




            #endregion

            #region Task7
            //            Kitabxana sistemi

            // Kitab təsviri üçün Data Structure yaratmaq -Book.cs

            // Kitabın təsviri üçün aşağıdakı memberlər olmalıdır

            // Kitabın adı(Name)

            //Müəllifin adı(AuthorName)

            //Nəşr ili(PublishedDate)

            //Səhifə sayı(PageCount) (10 - dan az reqem daxil etmek olmasin)

            //Həmçinin bu class daxilində (Book.cs)
            //--------------------------------------------------------------


            //1) ToString metodunun override edilməsi və tostring edilərkən
            //kitab haqqında məlumat aşağıdakı kimi çap edilsin

            // Format: <authorName> "<bookName>" <publishedDate>

            //Çingiz Abdullayev "Qərb bürküsü" 2013


            //Kitabları list şəklində depolamaq və sonra isə dövr opertorunun köməyi ilə
            //hər kitabı yuxarıdakı formatla hər sətrə çap etmək

            // 2) İkinci bir method olsun kitab obyektinin nusxesi uzre çağırılarkən aşağıdakı
            //formada tam məlumat qaytarsın



            //Əsər: Qərb bürküsü


            //Müəllif: Çingiz Abdullayev

            //Nəşr ili: 2013


            //Səhifə sayı: 300

            #endregion








        }
    }
}
