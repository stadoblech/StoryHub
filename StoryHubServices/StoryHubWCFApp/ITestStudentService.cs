﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StoryHubWCFApp
{
    /// <summary>
    /// Definice metod.
    /// </summary>
    [ServiceContract]
    public interface ITestStudentService
    {

        [OperationContract]
        [WebGet(UriTemplate = "Student/{ID}")]
        Student GetStudent(string ID);

        [OperationContract]
        [WebGet]
        List<Student> GetAllStudents();

        [OperationContract]
        [WebInvoke(UriTemplate = "AddStudent")]
        Tuple<bool,string> AddStudent(Student student);

        [OperationContract]
        [WebGet]
        string ActivationTest();

    }

    

    /*
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }*/
}
