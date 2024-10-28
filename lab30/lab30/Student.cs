using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab30
{
    public class Student : IStudent
    {
        public int StudID {  get; set; }
        public string StudName { get; set; }
        public string StudGender {  get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        private float studAvgMark;
        public float StudAvgMark
        {
            get { return studAvgMark; }
        }

        float IStudent.StudAvgMark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private int[] markList = new int[3];
        public int this[int index]
        {
            get { return markList[index]; }
            set
            {
                markList[index] = value;
            }
        }
        public void CalAvg()
        {
            int sum = 0;
            foreach (var mark in markList)
            {
                sum += mark;
            }
            studAvgMark = sum;
        }
        public void Print()
        {
            Console.WriteLine("StudID:" + StudID);
            Console.WriteLine("StudName:" + StudName);
            Console.WriteLine("StudGender:" + StudGender);
            Console.WriteLine("StudAge:" + StudAge);
            Console.WriteLine("StudClass:" + StudClass);
            Console.WriteLine("StudAvgMark:" + StudAvgMark);
        }
    }
}
