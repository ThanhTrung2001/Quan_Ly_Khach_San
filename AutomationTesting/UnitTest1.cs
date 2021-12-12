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
        [TestCase("", "", false)]
        [TestCase("", "admin", false)]
        //giamdoc
        [TestCase("giamdoc", "", false)]
        [TestCase("giamdoc", "admin", true)]
        [TestCase("giamdoc", "123456", false)]
        [TestCase("giamdoc", "blabla", false)]
        //letan
        [TestCase("letan", "", false)]
        [TestCase("letan", "admin", false)]
        [TestCase("letan", "123456", true)]
        [TestCase("letan", "blabla", false)]
        //daubep
        [TestCase("daubep", "", false)]
        [TestCase("daubep", "admin", false)]
        [TestCase("daubep", "123456", true)]
        [TestCase("daubep", "blabla", false)]
        //letan
        [TestCase("thukho", "", false)]
        [TestCase("thukho", "admin", false)]
        [TestCase("thukho", "123456", true)]
        [TestCase("thukho", "blabla", false)]
        //ketoan
        [TestCase("ketoan", "", false)]
        [TestCase("ketoan", "admin", false)]
        [TestCase("ketoan", "123456", true)]
        [TestCase("ketoan", "blabla", false)]

        [Test]
        public void Test_LoginFunction(string username, string password, bool answer)
        {
            Assert.AreEqual(answer, login_Testing.Login_Valid(username,password));
        }

        #endregion

        #region DichVu
        
            #region DichVu_SearchName_Testing
        [TestCase("", true)]
        [TestCase("@blabla", false)]
        [TestCase("S", true)]
        [TestCase("s", true)]
        [TestCase("Sauna ", true)]
        [TestCase("Sauna Evening", true)]
        [TestCase("Sauna Eveningffmfo", false)]

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
        [TestCase("@blabla", "all", false)]
        [TestCase("b", "all", true)]
        [TestCase("B", "all", true)]
        [TestCase("Beaf", "all", true)]
        [TestCase("BeafSteak", "all", true)]
        [TestCase("BeafSteakkkkk", "all", false)]



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
        [TestCase("@blabla", false)]
        [TestCase("T", true)]
        [TestCase("t", true)]
        [TestCase("Tran", true)]
        [TestCase("Thanh", true)]
        [TestCase("Trung", true)]
        [TestCase("tran thanh", true)]
        [TestCase("tran thanh trung", true)]
        [TestCase("tranthanhtrung", false)]

        [Test]
        public void Test_SearchCustomerNameFunction(string name, bool answer)
        {
            Assert.AreEqual(answer, khachHang_Testing.Search_Customer(name));
        }
            #endregion

            #region KhachHang_Add_Testing

        [TestCase("","","","","","", false)]

        [TestCase("", "hoang trung", "", "", "", "", false)]
        [TestCase("285020112", "hoang trung", "", "285020112", "", "", false)]
        [TestCase("285020111", "hoang trung", "", "285020111", "", "", false)]
        [TestCase("123ss56", "hoang trung", "", "123ss56", "", "", false)]

        [TestCase("", "hoang trung", "123456789", "", "", "", false)]
        [TestCase("285020112", "hoang trung", "123456789", "285020112", "", "", true)]
        [TestCase("285020111", "hoang trung", "123456789", "285020111", "", "", false)]
        [TestCase("123ss56", "hoang trung", "123456789", "123ss56", "", "", false)]

        [TestCase("", "hoang trung", "123ss56", "", "", "", false)]
        [TestCase("285020112", "hoang trung", "123ss56", "285020112", "", "", false)]
        [TestCase("285020111", "hoang trung", "123ss56", "285020111", "", "", false)]
        [TestCase("123ss56", "hoang trung", "123ss56", "123ss56", "", "", false)]

        [Test]
        public void Test_AddCustomerFunction(string identity, string name, string SDT, string CMND, string DiaChi, string GhiChu, bool answer)
        {
            Assert.AreEqual(answer, khachHang_Testing.Add_Customer(identity,name,SDT,CMND,DiaChi, GhiChu));
        }

        #endregion

        #endregion

        #region RuiRo

        #region RuiRo_Search_Testing
        [TestCase("", true)]
        [TestCase("@blabla", false)]
        [TestCase("d", true)]
        [TestCase("D", true)]
        [TestCase("Dirty", true)]
        [TestCase("Dirtyyy", false)]
        [TestCase("Dirty111", false)]

        [Test]
        public void Test_SearchRiskFunction(string text, bool answer)
        {
            Assert.AreEqual(answer, ruiRo_Testing.Search_Risk(text));
        }
        #endregion

        #region RuiRo_Add_Testing
        [TestCase("", "", 0, false)]
        [TestCase("", "Unfresh food", 0, false)]
        [TestCase("RR555", "", 0, false)]
        [TestCase("RR555", "Unfresh food", 0, false)]
        [TestCase("RR120", "", 0, false)]
        [TestCase("RR120", "Unfresh food", 0, true)]

        [Test]
        public void Test_AddRiskFunction(string id, string type, double refund, bool answer)
        {
            Assert.AreEqual(answer, ruiRo_Testing.Add_Risk(id,type,refund));
        }
        #endregion

       

        #endregion
    }
}