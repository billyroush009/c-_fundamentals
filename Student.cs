using System;

namespace C_
{
    //Class example
    public class Student
    {
        public string name, major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa){
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //object method example
        public bool HasHonors(){
            if(gpa >= 3.5){
                return true;
            }
            return false;
        }

    }
}