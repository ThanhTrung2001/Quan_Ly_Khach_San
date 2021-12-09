using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using BUS;

namespace AutomationTesting
{
    public class Tests
    {
        //Declare Variable/Call class have the testing function
        private Login_Testing login_Testing;
        private DichVu_Testing dichVu_Testing;
        private MonAn_Testing monAn_Testing;
        private KhachHang_Testing khachHang_Testing;
        private RuiRo_Testing ruiRo_Testing;


        [SetUp]
        public void Setup()
        {
            login_Testing = new Login_Testing();
            dichVu_Testing = new DichVu_Testing();
            monAn_Testing = new MonAn_Testing();
            khachHang_Testing = new KhachHang_Testing();
            ruiRo_Testing = new RuiRo_Testing();
        }


        #region Login_Testing

        [TestCase("giamdoc","admin",0)]
        [TestCase("giamdoc", "", -1)]


        [Test]
        public void Test_LoginFunction(string username, string password, int answer)
        {
            Assert.AreEqual(answer, login_Testing.Login_Valid(username,password));
        }

        #endregion

        #region DichVu

            #region DichVu_SearchId_Testing
        [TestCase("S001",true)]
        [TestCase("S005", false)]

        [Test]
        public void Test_SearchServiceIdFunction(string id, bool answer)
        {
            Assert.AreEqual(answer, dichVu_Testing.Search_Id(id));
        }
            #endregion

            #region DichVu_SearchName_Testing
        [TestCase("Sauna", true)]
        [TestCase("funny", false)]
        [TestCase("", true)]

        [Test]
        public void Test_SearchServiceNameFunction(string name, bool answer)
        {
            Assert.AreEqual(answer, dichVu_Testing.Search_Name(name));
        }
        #endregion

        #endregion

        #region MonAn

            #region MonAn_SearchName_Testing
        [TestCase("","all" , true)]

        [Test]
        public void Test_SearchFoodNameFunction(string name, string type, bool answer)
        {
            Assert.AreEqual(answer, monAn_Testing.Search_Name(name, type));
        }
        #endregion

        #endregion

        #region KhachHang

            #region KhachHang_Search_Testing

        [TestCase("", true)]

        [Test]
        public void Test_SearchCustomerNameFunction(string name, bool answer)
        {
            Assert.AreEqual(answer, khachHang_Testing.Search_Customer(name));
        }
            #endregion

            #region KhachHang_Add_Testing

        [TestCase("","","","","","", false)]
        [TestCase("251020112", "htoang trung", "0569842653", "251020112", "none", "none", true)]

        [Test]
        public void Test_AddCustomerFunction(string identity, string name, string SDT, string CMND, string DiaChi, string GhiChu, bool answer)
        {
            Assert.AreEqual(answer, khachHang_Testing.Add_Customer(identity,name,SDT,CMND,DiaChi, GhiChu));
        }

        #endregion

            #region KhachHang_Delete_Testing
        [TestCase("", false)]
        [TestCase("110", false)]
        [TestCase("285020111", true )]

        [Test]
        public void Test_DeleteCustomerFunction(string id, bool answer)
        {
            Assert.AreEqual(answer, khachHang_Testing.Delete_Customer(id));
        }

        #endregion

        #endregion

        #region RuiRo

        #region RuiRo_Search_Testing
        [TestCase("", true)]

        [Test]
        public void Test_SearchRiskFunction(string text, bool answer)
        {
            Assert.AreEqual(answer, ruiRo_Testing.Search_Risk(text));
        }
        #endregion

        #region RuiRo_Add_Testing
        [TestCase("", "", 0, false)]

        [Test]
        public void Test_AddRiskFunction(string id, string type, double refund, bool answer)
        {
            Assert.AreEqual(answer, ruiRo_Testing.Add_Risk(id,type,refund));
        }
        #endregion

        #region RuiRo_Delete_Testing
        [TestCase("", false)]

        [Test]
        public void Test_DeleteRiskFunction(string id, bool answer)
        {
            Assert.AreEqual(answer, ruiRo_Testing.Delete_Risk(id));
        }
        #endregion

        #endregion
    }
}