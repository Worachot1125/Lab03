using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Student
    {
        private string _name;
        private string _id;
        private int _birthYear;
        private double _weight;
        private double _grade;
        private string _major;

        public string Name
        {
            get { return this._name; }
        }
        public string ID
        {
            get { return this._id; }
        }
        public int Birthyear
        {
            get { return this._birthYear; }
        }
        public double Weight
        {
            get { return this._weight; }
        }
        public double Grade
        {
            get { return this._grade; }
        }
        public string Major
        {
            get { return this._major; }
        }

        //constructure
        public Student(string name,string id,int birhtYear,double weight,double grade,string major) 
        {
            this._name = name;
            this._id = id;
            this._birthYear = birhtYear;
            this._weight = weight;
            this._grade = grade;
            this._major = major;
        }

    }
}
