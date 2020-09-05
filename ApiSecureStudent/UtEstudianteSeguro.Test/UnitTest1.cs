using System;
using ApiSecureStudent.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net.Http;

namespace UtEstudianteSeguro.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetStudent()
        {
            //Arrange
            StudentsController studentsController = new StudentsController();
            //Act
            var ListaEstudiantes = studentsController.GetStudents();
            //Assert
            Assert.IsNotNull(ListaEstudiantes);
        }
    }
}
