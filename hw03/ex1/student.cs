using System;

namespace MyNameSpace
{
    class Student{
        private string _stunum;
        private string _group;
        private string _name;
        private string _gender;
        private int _age;
        public Student(string stunum,string group,string name,string gender,int age){
            this._stunum=stunum;
            this._group=group;
            this._name=name;
            this._gender=gender;
            this._age=age;
        }
		public string stunum{
			get{
				return this._stunum;
			}
		}
        public string group{
			get{
				return this._group;
			}
		}
        public string name{
			get{
				return this._name;
			}
		}
        public string gender{
			get{
				return this._gender;
			}
		}
        public int age{
			get{
				return this._age;
			}
            set{
                this._age = value;
            }
		}
    }  
    class test{
        static void Main(){
            Student a = new Student("2017302580256","卓越二班","黄煜坤","男",19);
            Console.WriteLine(a.stunum);
            Console.WriteLine(a.group);
            Console.WriteLine(a.name);
            Console.WriteLine(a.gender);
            Console.WriteLine(a.age);
            a.age=20;
            Console.WriteLine(a.age);
        }
    }
}

