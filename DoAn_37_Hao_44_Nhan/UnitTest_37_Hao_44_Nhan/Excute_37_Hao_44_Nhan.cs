using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTest_37_Hao_44_Nhan
{
    [TestClass]
    public class Excute_37_Hao_44_Nhan
    {
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void TC1_DangNhapThanhCong_37_Hao_44_Nhan()
        {
            // Ẩn cửa sổ dòng lệnh của ChromeDriver để tránh hiển thị cửa sổ đen
            ChromeDriverService chrome_37_Hao_44_Nhan = ChromeDriverService.CreateDefaultService();
            chrome_37_Hao_44_Nhan.HideCommandPromptWindow = true;

            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_37_Hao_44_Nhan = new ChromeDriver(chrome_37_Hao_44_Nhan);

            // Điều hướng đến trang chủ của Fahasa
            driver_37_Hao_44_Nhan.Navigate().GoToUrl("https://www.fahasa.com/");

            // Tạm dừng 1 giây để đảm bảo trang được tải đầy đủ
            Thread.Sleep(1000);

            // Tìm và nhấn vào nút đăng nhập trên thanh điều hướng
            IWebElement icon_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.ClassName("fhs_top_account_button"));
            icon_37_Hao_44_Nhan.Click();

            // Tạm dừng 1 giây để giao diện hiển thị form đăng nhập
            Thread.Sleep(1000);

            // Tìm ô nhập tên đăng nhập (số điện thoại/email) và nhập thông tin đăng nhập
            IWebElement user_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.Id("login_username"));
            user_37_Hao_44_Nhan.SendKeys("0335607157");

            // Tạm dừng 1 giây để dữ liệu nhập được xử lý
            Thread.Sleep(1000);

            // Tìm ô nhập mật khẩu và nhập mật khẩu
            IWebElement pass_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.Id("login_password"));
            pass_37_Hao_44_Nhan.SendKeys("T123456789");

            // Tạm dừng 1 giây để dữ liệu nhập được xử lý
            Thread.Sleep(1000);

            // Tìm và nhấn vào nút đăng nhập
            IWebElement login_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.ClassName("fhs-btn-login"));
            login_37_Hao_44_Nhan.Click();

            // Tạm dừng 1 giây để trang tải sau khi đăng nhập
            Thread.Sleep(1000);

            try
            {
                // Kiểm tra xem link trả về có đúng với trang đang hướng đến hay không 
                string expected_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.Url;

                // Nếu đúng, xác nhận rằng đăng nhập thành công
                Assert.AreEqual(expected_37_Hao_44_Nhan, "https://www.fahasa.com/customer/account/");
            }
            catch (NoSuchElementException)
            {
                // Nếu không tìm thấy phần tử mong đợi, kết luận test thất bại
                Assert.Fail("Test Failed");
            }

            // Đóng trình duyệt sau khi hoàn thành test
            driver_37_Hao_44_Nhan.Quit();
        }



        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                         @".\Data_37_Hao_44_Nhan\DangNhapThanhCong_TestData_37_Hao_44_Nhan.csv",
                            "DangNhapThanhCong_TestData_37_Hao_44_Nhan#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TC2_DangNhapThatBai_37_Hao_44_Nhan()
        {
            // Ẩn cửa sổ dòng lệnh của ChromeDriver để tránh hiển thị cửa sổ đen
            ChromeDriverService chrome_37_Hao_44_Nhan = ChromeDriverService.CreateDefaultService();
            chrome_37_Hao_44_Nhan.HideCommandPromptWindow = true;

            // Khởi tạo trình duyệt Chrome
            IWebDriver driver_37_Hao_44_Nhan = new ChromeDriver(chrome_37_Hao_44_Nhan);

            // Điều hướng đến trang chủ của Fahasa
            driver_37_Hao_44_Nhan.Navigate().GoToUrl("https://www.fahasa.com/");

            // Tạm dừng 1 giây để đảm bảo trang được tải đầy đủ
            Thread.Sleep(1000);

            // Tìm và nhấn vào nút đăng nhập trên thanh điều hướng
            IWebElement icon_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.ClassName("fhs_top_account_button"));
            icon_37_Hao_44_Nhan.Click();

            // Tạm dừng 1 giây để giao diện hiển thị form đăng nhập
            Thread.Sleep(1000);

            // Lấy số điện thoại từ file CSV (cột 0) và loại bỏ ký tự đầu tiên nếu có
            IWebElement user_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.Id("login_username"));
            string sdt_37_Hao_44_Nhan = TestContext.DataRow[0].ToString();

            // Loại bỏ ký tự đầu tiên 
            sdt_37_Hao_44_Nhan = sdt_37_Hao_44_Nhan.Remove(0, 1); 

            //Nhập dữ liệu vào username
            user_37_Hao_44_Nhan.SendKeys(sdt_37_Hao_44_Nhan);

            // Tạm dừng 1 giây để dữ liệu nhập được xử lý
            Thread.Sleep(1000);

            // Lấy mật khẩu từ file CSV (cột 1)
            IWebElement pass_37_Hao_44_Login = driver_37_Hao_44_Nhan.FindElement(By.Id("login_password"));
            string mk_37_Hao_44_Nhan = TestContext.DataRow[1].ToString();

            //Nhập dữ liệu vào password
            pass_37_Hao_44_Login.SendKeys(mk_37_Hao_44_Nhan);

            // Tạm dừng 1 giây để dữ liệu nhập được xử lý
            Thread.Sleep(1000);

            // Tìm và nhấn vào nút đăng nhập
            IWebElement login_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.ClassName("fhs-btn-login"));
            login_37_Hao_44_Nhan.Click();

            // Tạm dừng 2 giây để trang tải thông báo lỗi
            Thread.Sleep(2000);

            try
            {
                // Kiểm tra xem thông báo lỗi đăng nhập có xuất hiện không
                IWebElement expected_37_Hao_44_Nhan = driver_37_Hao_44_Nhan.FindElement(By.CssSelector(".fhs-popup-msg.fhs-login-msg"));

                // Nếu tìm thấy phần tử, xác nhận rằng đăng nhập thất bại thành công (tức là hệ thống hiển thị lỗi)
                Assert.IsNotNull(expected_37_Hao_44_Nhan, "Test Passed: Login failed as expected!");
            }
            catch (NoSuchElementException)
            {
                // Nếu không tìm thấy thông báo lỗi, kết luận test thất bại
                Assert.Fail("Test Failed: Login should have failed but did not.");
            }

            // Đóng trình duyệt sau khi hoàn thành test
            driver_37_Hao_44_Nhan.Quit();
        }

    }
}
