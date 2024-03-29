﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPFmitEF.Models
{
    internal class StudentsViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public StudentsViewModel()
        {
            NewStudent = new Student();
            MyStudents = new ObservableCollection<Student>();
            SearchResult = new ObservableCollection<Student>();
            var myStudentsLocalFromDB = db.Students.ToList();
            foreach (var student in myStudentsLocalFromDB)
            {
                MyStudents.Add(student);
                SearchResult.Add(student);
            }
            StatusAnzeige = "Momentan sind " + db.Students.ToList().Count + " Studierende in der DB";
            OnPropertyChanged("StatusAnzeige");
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Student NewStudent { get; set; }
        public ObservableCollection<Student>  MyStudents { get; set; }

        public string StatusAnzeige { get; set; }

        Campus02DBContext db = new Campus02DBContext();
        public void AddStudent(Student newStudent)
        {
            MyStudents.Add(newStudent);
            //Check if exists
            db.Students.Add(newStudent);
            db.SaveChanges();
            StatusAnzeige = "Momentan sind " + db.Students.ToList().Count + " Studierende in der DB";    
            OnPropertyChanged("StatusAnzeige");

        }

        public ObservableCollection<Student> SearchResult { get; set; }

        private string _Suchbegriff;

        public string Suchbegriff
        {
            get { return _Suchbegriff; }
            set { 
                _Suchbegriff = value; 
                SearchStudent(_Suchbegriff);
            }
        }

        public void SearchStudent(string searchName)
        {
            SearchResult.Clear();
            foreach (var student in MyStudents)
            {
                if (student.Name.Contains(searchName))
                {
                    SearchResult.Add(student);
                }
            }
        }
    }
}
