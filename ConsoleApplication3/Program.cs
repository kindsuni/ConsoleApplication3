using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {

        //할인값 계산
        public static float sale(float price, float coupon)
        {
            float sale;
            sale = price - (price * coupon);

            return sale;


        }
        //두번째로 큰 정수
        public static int secondnum(int a, int b, int c)
        {
            int sec;
            // 10,20,30
            if (a <= b && b <= c)
            {
                sec = b;
            }
            else if (a >= b && b >= c)
            {
                sec = b;
            }
            else if (a <= c && c <= b)
            {
                sec = c;
            }
            else if (a >= c && c >= b)
            {
                sec = c;
            }
            else
            {
                sec = a;
            }
            return sec;
        }
        // 1만까지의 자연수중 원하는 배수값을 모두 더한 값
        public static int beasu(int a)
        {
            int baesu = a;
            int sum = 0;
            int max = 10000;
            for (int i = 1; i <= max; i++)
            {
                if (i % baesu == 0)
                {
                    sum += i;
                }

            }
            return sum;
        }
        //배열들의 평균값보다 작은수들의 비율
        public static float ratio(int[] a)
        {
            int sum = 0;
            int average = 0;
            int count = 0;
            float ratio = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i]; //배열들의 합
                average = sum / a.Length;  //평균

            }
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] <= average)
                {
                    count++;// 평균보다 작은 값의 수
                }

            }
            ratio = (float)count / a.Length * 100; // 전체 수에서 평균 보다 작은값의 비율
            Console.WriteLine("평균은 " + average);
            return ratio;

        }

        //시험 점수 받아서 채점
        public static string Grades(int score) //점수를 받아서 string으로 돌려줌
        {
            string gd = null; //결과값 리턴
            string a = "A", b = "B", c = "C", d = "D", f = "F"; //채점



            if (score >= 90)  //90과 같거나 크면 결과값 A
            {
                gd = a;
            }

            else if (score >= 80 && score <= 89)  //80~89에 해당하면 B
            {
                gd = b;
            }

            else if (score >= 70 && score <= 79) //70~79에 해당하면 C
            {
                gd = c;
            }
            else if (score >= 60 && score <= 69) //60~69에 해당하면 D
            {
                gd = d;
            }
            else                                // 해당하지 않으면 F
            {
                gd = f;
            }


            return gd;


        }

        //사탕 나눔 메서드
        public static void Candy(int a, int b)
        {
            int average = 0;
            int papa = 0;



            if (a == 2 & b == 1)
            {
                Console.WriteLine("형제에게 한명당 " + 1 + "개 만큼 나눠주고 아빠는 " + 1 + "개만큼 가진다");
            }
            else if (b == 0)
            {
                Console.WriteLine("아빠가 " + a + "개를 다 가진다");
            }
            else
            {
                average = a / b;
                papa = a - (average * b);

                Console.WriteLine("형제에게 한명당 " + average + "개 만큼 나눠주고 아빠는 " + papa + "개만큼 가진다");
            }


        }
        //2007년의 원하는 월일의 요일을 구함
        public static void MD(int m, int d)
        {
            string Mn = "월요일", tu = "화요일", we = "수요일", th = "목요일", fr = "금요일", st = "토요일", su = "일요일";
            DateTime dt = new DateTime(2007, m, d);

            if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine(dt + "의 요일은 " + Mn + " 입니다.");
            }
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                Console.WriteLine(dt + "의 요일은 " + tu + " 입니다.");
            }
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine(dt + "의 요일은 " + we + " 입니다.");
            }
            if (dt.DayOfWeek == DayOfWeek.Thursday)
            {
                Console.WriteLine(dt + "의 요일은 " + th + " 입니다.");
            }
            if (dt.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine(dt + "의 요일은 " + fr + " 입니다.");
            }
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine(dt + "의 요일은 " + st + " 입니다.");
            }
            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine(dt + "의 요일은 " + su + " 입니다.");
            }

        }

        //받은 5개의 점수를 40점이하는 40점으로 고친뒤 5개의 평균을 계산 해줌

        public static void Average(int[] score)
        {
            int sum = 0, average = 0;
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] < 40)
                {
                    score[i] = 40;
                }
                sum += score[i];
                average = sum / score.Length;
            }
            for (int j = 0; j < score.Length; j++)
            {
                Console.WriteLine("새로 받은 점수는 " + score[j]);

            }
            Console.WriteLine("평균은 " + average);
        }

        //구구단 출력 메서드
        public static void gugu(int a)
        {
            int multiply = 0;
            for (int i = 1; i < 10; i++)
            {
                multiply = a * i;


                Console.WriteLine("" + a + " * " + i + " = " + multiply);
            }



        }
        //무게
        public static void pack(int weight)
        {
            int suga = 3;
            int suga2 = 5;
            int bj1 = 0;
            int bj2 = 0;
            if (weight % suga2 == 0)
            {
                bj2 = weight / suga2;
            }
            else if (weight % suga2 == 1)
            {
                bj1 = 6 / suga;
                bj2 = (weight - 6) / suga2;
            }
            else if (weight % suga2 == 2)
            {
                bj1 = 4;
                bj2 = (weight - 12) / suga2;

            }
            else if (weight % suga2 == 3)
            {
                bj1 = 1;
                bj2 = (weight - 1) / suga2;
            }
            else if (weight % suga2 == 4)
            {
                bj1 = 3;
                bj2 = (weight - 9) / suga2;
            }

            Console.WriteLine(suga + "kg " + bj1 + "개, " + suga2 + "kg " + bj2 + "개");
        }
        // 배열의 원하는 번째의 값을 돌려줌
        public static void arrnum(int[] a, int input)
        {
            int i = 0, j = 0;
            int result = 0;
            for (i = 0; i < a.Length; i++)
            {
                for (j = i; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }

                }

            }
            for (int k = 0; k < a.Length; k++)
            {
                if (k == input)
                {
                    result = a[k];
                }

            }

            Console.WriteLine(result);



        }
        //작은값
        public static int Min(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = b;
            }
            else
            {
                result = a;
            }
            return result;
        }
        //3개중 가장 큰값
        public static int Best(int a, int b, int c)
        {
            int result = 0;
            if (a > b && a > c)
            {
                result = a;

            }
            else if (a < c && c > b)
            {
                result = c;
            }

            else
            {
                result = b;
            }

            return result;

        }
        //3개중 가장 작은값
        public static int Lower(int a, int b, int c)
        {
            int result = 0;
            if (a < b && a < c)
            {
                result = a;

            }
            else if (a > c && b > c)
            {
                result = c;
            }

            else
            {
                result = b;
            }

            return result;
        }
        //두개의 정수 a,r받아 a에 r승수 계산하여 돌림
        public static Double Power(double a, double b)
        {
            double result = 0;
            result = Math.Pow(a, b);

            return result;

        }
        //정수 배열 파라미터로 받아 배열안 모든 정수의 합을 돌려줌
        public static void ArraySum(int[] a)
        {
            int i = 0;
            int sum = 0;
            for (i = 0; i < a.Length; i++)
            {

                sum += a[i];


            }
            Console.WriteLine(sum);
        }
        //정수 배열을 파라미터로 받아 배열안 정수들 중 가장큰 값 돌림
        public static void ArrayMax(int[] a)
        {
            int i = 0;
            int max = a[0];
            for (i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    int tmp = max;
                    max = a[i];
                    a[i] = tmp;

                }
            }
            Console.WriteLine(max);

        }
        //정수 배열을 파라미터로 받아 배열안 정수들 중 가장큰 값 돌림
        public static void ArrayMin(int[] a)
        {
            int i = 0;
            int min = a[0];
            for (i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    int tmp = min;
                    min = a[i];
                    a[i] = tmp;

                }
            }
            Console.WriteLine(min);
        }
        //정수 배열을 파라미터로 받아 배열의 모든 정수들의 평균값을 돌림
        public static void ArrayAverage(int[] a)
        {
            int i = 0;
            int count = 0;
            int average = 0;
            int sum = 0;
            for (i = 0; i < a.Length; i++)
            {
                sum += a[i];
                count = i + 1;
            }
            average = sum / count;

            Console.WriteLine(average);
        }
        ////배열중 입력한 정수가 있으면 참, 없으면 거짓을 돌림
        public static void ArrayIsin(int[] a, int input)
        {
            int i = 0;
            bool isin = false;
            for (i = 0; i < a.Length; i++)
            {
                if (input == a[i])
                {
                    isin = true;
                }



            }
            if (isin == true)
            {
                Console.WriteLine("있다");
            }
            else
            {
                Console.WriteLine("없다");
            }
        }
        //배열중 입력한 정수가 몇개 있는지 돌림
        public static int ArrayFrequency(int[] a, int input)
        {
            int i = 0;
            int count = 0;
            bool isin = false;
            for (i = 0; i < a.Length; i++)
            {
                if (input == a[i])
                {
                    isin = true;
                    if (isin == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        //배열을 입력받아 배열중 가장 많이 나오는 정수를 돌려줌
        public static int ValueOfMaxFrequency(int[] a)
        {
            int i, j, max = 0;

            for (i = 0; i < a.Length; i++)
            {

            }
            return max;

        }

        //a와 b를 받아 자리교체
        public static void Swap(ref int a, ref int b)
        {
            int sw = a;
            a = b;
            b = sw;

        }
        //리버스(배열의 순서를 바꿈)
        public static void Revers(int[] a)
        {
            int l = a.Length;
            int t = 0;

            int i = 0;
            for (i = 0; i < l / 2; i++)

            {
                t = a[i];
                a[i] = a[l - i - 1];
                a[l - i - 1] = t;

            }
            Console.WriteLine("Reverse");


        }
        //피보나치 재귀 호출
        public static int Pivonachi(int input)
        {


            if (input <= 2)
                return 1;
            else
                return Pivonachi(input - 1) + Pivonachi(input - 2);




        }
        //더하기
        public static int Plus(int a, int b)
        {

            return a + b;
        }
        public static long Plus(long a, long b)

        {

            return a + b;
        }
        // 셀렉션 메소드
        public static void Selectionshort(int[] comarr)
        {

            int i = 0, j = 0;

            for (i = 0; i < comarr.Length; i++)
            {
                for (j = i; j < comarr.Length; j++)
                {
                    if (comarr[i] > comarr[j])
                    {
                        int tmp = comarr[i];
                        comarr[i] = comarr[j];
                        comarr[j] = tmp;
                    }

                }

            }

        }
        //LinkedList로 Stack구현
        class Node
        { //노드는 값(val) 과 다음값을 가르키는 주소(Next)를 가진다
            public int val;
            public Node next;
        }
        class myStack //입력 받은값을 역순으로 출력하는 클래스
        {
            Node head = null; //처음 헤드와 탑은 비어있는 값
            Node top = null;

            public void push(int val) //입력 받은 Int형 값들을 저장 하는 메소드
            {
                Node tmpNode = new Node(); //값을 받을 Node의 변수를 tmpNode를 지정해줌
                tmpNode.val = val;     //입력 받은 Val값을 지정한 tmpNode.val에 저장
                tmpNode.next = null;  // 다음 입력이 없으면 tmpNode.nexe(다음 주소)는 비어있음.
                                      //tmpNode는 움직이지 않고 입력만 받은 상태이므로 입력받은 값들이 서로 연결되지 않은 상태.
                if (head != null) //head가 Null이 아닐때
                {
                    Node tmpNode2 = head; // 루프문을 돌 임의의 Node를 지정해서 tmpNode2가 돌아다니면서 끝을 찾음.
                    for (; tmpNode2.next != null;) //tmpNode2.next가 Null값이 되면 루프를 빠져나옴
                    {                           //(입력된 값의 마지막은 항상 Null이기 때문에 끝을 판단함)
                        tmpNode2 = tmpNode2.next; //Null(끝)이 될때까지 tmpNode2를 Next로 바꿔주어 한칸씩 옮김
                    }
                    tmpNode2.next = tmpNode; //마지막 값을 찾았으면 그 값을 tmpNode2.next에 저장.
                    top = tmpNode; // 끝에 도달 했을때 top에 tmpNode값을 저장.
                }
                else //head 가 Null일때 
                {
                    head = tmpNode; // 헤드가 비어있으면 그 곳에 받은 값을 저장함.(저장되면 if문으로 들어감.)
                }
            }
            public int pop() //입력 받은 Int형 값들을 역순으로 빼내는 메소드
            {

                Node curNode = head; //head는 움직이면 안되므로 임의의 값에 head를 저장하여 이용

                if (top != null)
                {
                    if (head != top) //head가 top이 아닐때
                    {
                        for (; curNode.next != top;) //curNode.next가 top이 될때 까지
                            curNode = curNode.next; // curNode값을 Next로 이동
                        int returnVal = top.val;

                        top.next = null; //top다음 값을 비어둠.
                        top = curNode; //top값을 마지막 값으로 바꿈.
                        return returnVal;
                    }
                    else //head 와 top이 같을때 리턴후 두값을 null로 
                    {
                        int returnVal = top.val;
                        head = null;
                        top = null;
                        return returnVal;
                    }
                }
                else
                {     //둘다 null이면 비었음
                    Console.WriteLine("비었음");
                    return 0;
                }


            }

        }




        // Stack ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd
        class OwnStack
        {
            int[] intArr = new int[10];
            int top = 0;

            public void Push(int val)
            {
                if (top < intArr.Length)
                {
                    intArr[top] = val;
                    top++;
                }
                else
                {
                    Console.WriteLine("Stack이 꽉참");
                }

            }
            public int pop()
            {
                if (top > 0)
                {
                    return intArr[--top];

                }
                else
                {
                    Console.WriteLine("Stack이 비어있음");
                    return -1;
                }
            }

        }



        //Queue pppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp
        class MyQueue
        {


            int[] intArr = new int[10];
            int head = -1;
            int tail = 0;

            public void enqueue(int val)
            {
                if (head == -1)
                {
                    intArr[tail++] = val;
                    head = 0;
                }
                else if (tail < intArr.Length)
                {
                    intArr[tail++] = val;
                }
                else
                    Console.WriteLine("Queue가 가득 찼습니다.");

            }

            public int dequeue()
            {
                if (head == -1)
                {
                    Console.WriteLine("Queue가 비어있습니다.");
                    return -1;
                }
                else if (head < tail)
                {
                    return intArr[head++];
                }
                else
                {
                    Console.WriteLine("Queue가 비어있습니다.");
                    return -1;
                }
            }

        }





        static void Main(string[] args)

        {
            myStack Go = new myStack();
            for (int i = 1; i < 10; i++)
            {
                Go.push(i);
            }

            for (int i = 1; i < 10; i++)
            {
             Console.WriteLine(   Go.pop());
            }
            /*
    MyQueue de = new MyQueue();

    for (int i = 1; i < 11; i++)
    {
        de.enqueue(i);
    }
    for (int i=1; i<11; i++)
    {
        Console.WriteLine(de.dequeue());
    }
    */

            /*
            OwnStack stackInt = new OwnStackInt();

            stackInt.Push(1);
            stackInt.Push(2);
            stackInt.Push(3);
            stackInt.Push(4);
            stackInt.Push(5);
            stackInt.Push(6);
            stackInt.Push(7);
            stackInt.Push(8);
            stackInt.Push(9);
            stackInt.Push(10);
            stackInt.Push(11);

            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            Console.WriteLine(stackInt.Pop());
            */

            //가격 할인 메서드 실행
            /*
            float coupon = 0.2f;
            float price = 0;
            

            Console.Write(""+(coupon*100)+"% 쿠폰이 있다. 제품의 가격을 입력 하시오: ");
           price= Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("그 제품은 " + (price * coupon) + "원 만큼 할인되어" + sale(price,coupon) + "원 이다");
            */

            //세 정수 입력받아서 2번째로 큰 정수를 돌려주는 메서드
            /*
            int first, second, third;
            Console.Write("세 정수를 입력하시오: ");
           first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(secondnum(first, second, third));
            */
            //1만까지 자연수 중 원하는 배수값을 모두 더한 값
            /*
            int a = 5;
            int sum = 0;
            Console.WriteLine(beasu(a));
            */

            //배열의 정수들의 평균값 보다 작은 정수들의 비율을 돌려주는 메서드
            /*
            int[] arr = new int[] { 10, 40, 50, 20, 60, 80, 90, 110 };
            
           Console.WriteLine("평균값보다 적은 수의 비율은 "+ratio(arr)+"%");
        */

            /*
             int[] arr = new int[] { 60, 90, 80, 50, 45 };
             int[] arr2 = new int[5];
             int max = arr[0], average = 0, sum = 0;
             for (int i = 0; i < arr.Length; i++)
             {
                 if (max <= arr[i])
                 {
                     max = arr[i];
                 }

             }
             for (int j = 0; j < arr.Length;)
             {
                 int b = 0;
                 arr2[b++] = arr[j++] / max * 100;
                 sum += arr2[b];
                 average = sum / arr2.Length;
                 Console.WriteLine(max);
             }

             Console.WriteLine(arr2[0]);
             */


            //시험 점수 100~90 a,89~80 b 79~70 c 69~60 d ,f
            /*
            int score = 0;
            Console.Write("점수를 입력 하세요 : ");
            score = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(Grades(score));
           */
            //사탕개수와 형제 수에 비례하게 나눠준후 나머지는 아빠가 가짐
            /*
             Console.Write("사탕개수와 형제 수를 입력 : ");
             int candy = 0, bro = 0;
             candy = Convert.ToInt32(Console.ReadLine());
             bro= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("사탕 개수 : " + candy + " 형제 수 : " + bro);
             Candy(candy, bro);
             */


            //2007년의 요일을 말해줌
            /*
            int month = 0, day = 0;
            Console.Write("2007년의 알고 싶은 요일의 월과 일을 적으시오 : ");
            month = Convert.ToInt32(Console.ReadLine());
            day = Convert.ToInt32(Console.ReadLine());
            MD(month, day);
            */
            //입력받은 5개의 점수중 40점 이하는 보충학습으로 40점으로 받고 5개의 평균 점수를 구하는 메서드
            /*
            int[] score = new int[5];          
            score[0] = Convert.ToInt32(Console.ReadLine());
            score[1] = Convert.ToInt32(Console.ReadLine());
            score[2] = Convert.ToInt32(Console.ReadLine());
            score[3] = Convert.ToInt32(Console.ReadLine());
            score[4] = Convert.ToInt32(Console.ReadLine());

            Average(score);
            */
            //10개씩 정렬해서 출력
            /*
            int[] arr = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17,18 ,19 , 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 };
            for(int i=0; i<arr.Length;i++)
            {
                Console.Write(" "+arr[i]);
                
                if (i%10==0&&i>1)
                {
                    Console.WriteLine();
                }
                if(i==arr.Length-1)
                {
                    Console.WriteLine();
                }

            }
            */

            /*
            //구구단 출력 메서드
            Console.Write("원하는 구구단의 단을 입력(1~9): ");
            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            gugu(num);
            */

            // 3킬로그램,5킬로그램 봉지로 원하는 킬로그램을 최대한 적은 수의 봉지만큼
            /*
            int kg = 0;
            Console.Write("킬로그램 입력 : ");            
            kg = Convert.ToInt32(Console.ReadLine());
            pack(kg);
            */

            //배열과 정수를 입력으로 받아 받은 정수 번째의 배열에 해당하는 값을 돌려주는 메서드
            /*
            int[] arr = new int[] { 2, 6, 10, 29, 3, 54, 62, 20, 40, 50, 60, 70 };
            int num = 0;
            Console.Write("배열의 원하는 위치값(배열크기 0~11) : ");
            
            num = Convert.ToInt32(Console.ReadLine());
            if(arr.Length-1<num)
            {
                Console.WriteLine("배열의 크기보다 크게 입력되었습니다.");
              
            }
            else
            {
               arrnum(arr, num);
            }
            */
            //셀렉션(머지)
            /*
            int[] arr = new int[] { 3, 4, 7, 10, 15, 19, 23, 25, 40, 42 };
            int[] arr2 = new int[] { 1, 2, 5, 20, 28, 30, 31, 32, 33, 43 };
            int[] arr3 = new int[20];
            int i = 0;
            int j = 0;
            int merged = 0;
            for (; i < arr.Length && j < arr2.Length;)
            {
                if (arr[i] < arr2[j])

                    arr3[merged++] = arr[i++];

                else
                    arr3[merged++] = arr2[j++];

            }

            if (i < arr.Length)
                for (; i < arr.Length;)

                    arr3[merged++] = arr[i++];

            else

                for (; j < arr2.Length;)

                    arr3[merged++] = arr2[j++];



            Console.WriteLine(arr3[0]);

    */
            //두 선이 만나는지 안만나는지 
            /*
            float line1_start = 1.0f;
            float line1_end = 10.0f;

            float line2_start = -5.0f;
            float line2_end = -3.0f;

            if (line1_start < line2_start && line1_end < line2_end)
            {
                Console.WriteLine("안만난다");
            }
            else if (line1_start > line2_start && line1_end > line2_end)
            {
                Console.WriteLine("안만난다");
            }
            else
            {
                Console.WriteLine("만난다");
            }
            */
            //작은값
            /* int x = 54, y=23;
             Console.WriteLine(Min(x, y));
             */

            //3개중 가장 큰값
            /*  int x = 15, y = 60, z = 70;
              Console.WriteLine(Best(x, y, z)); 
              */

            //3개중 가장 작은값
            /* int x = 15, y = 51, z = 1;
             Console.WriteLine(Lower(x, y, z));
             */

            //두개의 정수 a,r을 파라미터로 받아 a^r을 돌려줌
            /*  double a = 2, r = 3;
              Console.WriteLine(Power(a,r));*/

            //정수 배열을 파라미터로 받아 배열 안 모든 정수의 합을 돌림
            /* int[] sumarr = new int[10] { 4, 5, 3, 5, 2, 5, 6, 32, 5, 6 };     
              ArraySum(sumarr);
              */

            //정수 배열을 파라미터로 받아 배열안 정수들 중 가장큰 값 돌림
            /* int[] arr = new int[10] { 5, 4, 6, 1, 67, 344, 638, 23, 15, 64 };
             ArrayMax(arr);
             */

            //정수 배열을 파라미터로 받아 배열안 정수들 중 가장 작은 값 돌림
            /*int[] arr = new int[10] { 5, 4, 6, 1, 67, 344, 638, 23, 15, 64 };
            ArrayMin(arr);
            */

            //정수 배열을 파라미터로 받아 배열의 모든 정수들의 평균값을 돌림
            /* int[] arr = new int[5] { 5, 7, 8, 2, 3 };
             ArrayAverage(arr);
            */
            //배열중 입력한 정수가 있으면 참, 없으면 거짓을 돌림
            /* int[] arr = new int[] { 5, 5, 23, 5, 15, 2, 6, 216, 754, 53, 45, 2, 4523, 6, 52, 15, 12, 312 };
             int input = 0;
             Console.Write("아무 숫자 적으시오 : ");
               input= Convert.ToInt32(Console.ReadLine());
                 Console.Write(""+input+"은(는)");
             ArrayIsin(arr,input);
             */
            //배열중 입력한 정수가 몇개 있는지 돌림
            /*
            int[] arr = new int[] { 5, 7, 5, 2, 56, 1, 6, 3, 6, 2, 10, 2, 4, 5, 20 };
             int input = 0;
             Console.Write("아무 숫자 적으시오 : ");
             input = Convert.ToInt32(Console.ReadLine());
             Console.Write("" + input + "은(는)");             
            Console.WriteLine(ArrayFrequency(arr, input)+"개");
             */

            //배열을 입력받아 배열중 가장 많이 나오는 정수를 돌려줌
            /*  int[] arr = new int[] { 2, 3, 5, 6, 9, 10, 2, 5, 6, 7,2 };
              Console.Write( ValueOfMaxFrequency(arr));
               */

            //두개의 정수 a,b를 받아 a는 b,b는 a로 바꾸는 Swap메소드
            /*int x = 50, y = 20;
            
            Swap(ref x,ref y);
            Console.WriteLine("x="+x);
            Console.WriteLine("y=" + y);
            */

            //리버스 
            /*  int[] arr = new int[] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };

              Revers(arr);
         */

            //재귀 호출 피보나치
            /*
                        int input = 0;
                      input=Convert.ToInt32(Console.ReadLine());

                       Console.WriteLine( Pivonachi(input));
                       */
            /*
 int x = 5, y = 10;

 Console.WriteLine(Plus(x, y));
 */

            //셀렉션 메소드
            /*
            int[] arr = new int[10] { 5, 10, 40, 52, 64, 23, 56, 62, 26, 53 };
            int[] arr2 = new int[10] { 1, 3, 65, 72, 23, 66, 74, 22, 16, 76 };

            int i = 0, j = 0;
            int[] merged = new int[20];
            Selectionshort(arr);
            Selectionshort(arr2);
            for (i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]);
                //  Console.WriteLine(arr2[i]);
            }
            */



        }


    }


}
