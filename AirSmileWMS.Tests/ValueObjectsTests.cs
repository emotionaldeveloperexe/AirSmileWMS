using System;
using System.IO;
using Xunit;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Tests
{
    public class ValueObjectsTests
    {
        private const string ValidImageFile = "test_image.png";
        private const string ValidQRFile = "test_qr.svg";

        public ValueObjectsTests()
        {
            // Создаем временные файлы для тестов
            if (!File.Exists(ValidImageFile))
                File.WriteAllText(ValidImageFile, "dummy");

            if (!File.Exists(ValidQRFile))
                File.WriteAllText(ValidQRFile, "dummy");
        }

        #region Amount Tests
        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(int.MaxValue)]
        public void Amount_Should_Accept_NonNegative(int value)
        {
            Amount amount = value;
            Assert.Equal(value, amount.Value);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        public void Amount_Should_Throw_On_Negative(int value)
        {
            Assert.Throws<ArgumentException>(() => { Amount a = value; });
        }

        [Fact]
        public void Amount_Arithmetic_Should_Work()
        {
            Amount a = 10;
            Amount b = 5;

            Assert.Equal(15, (a + b).Value);
            Assert.Equal(5, (a - b).Value);
            Assert.Equal(50, (a * 5).Value);
            Assert.Equal(50, (5 * a).Value);
            Assert.Equal(2, (a / 5).Value);
            Assert.Equal(0, (a % 5).Value);
        }

        [Fact]
        public void Amount_Should_Throw_On_DivideByZero()
        {
            Amount a = 10;
            Assert.Throws<DivideByZeroException>(() => { var _ = a / 0; });
            Assert.Throws<DivideByZeroException>(() => { var _ = a % 0; });
        }
        #endregion

        #region Name & SKU
        [Theory]
        [InlineData("Balloon Set")]
        [InlineData("   Something   ")]
        public void Name_Should_Trim_And_Store(string name)
        {
            Name n = name;
            Assert.Equal(name.Trim(), n.Value);
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        public void Name_Should_Throw_On_Empty(string name)
        {
            Assert.Throws<ArgumentException>(() => { Name n = name; });
        }

        [Theory]
        [InlineData("ABC123")]
        [InlineData("sku-xyz")]
        public void SKU_Should_Accept(string sku)
        {
            SKU s = sku;
            Assert.Equal(sku.Trim(), s.Value);
        }

        [Theory]
        [InlineData("")]
        [InlineData("  ")]
        public void SKU_Should_Throw_On_Empty(string sku)
        {
            Assert.Throws<ArgumentException>(() => { SKU s = sku; });
        }
        #endregion

        #region Barcode & PIN
        [Theory]
        [InlineData("123456")]
        [InlineData("0")]
        public void Barcode_Should_Accept_Digits(string code)
        {
            Barcode b = code;
            Assert.Equal(code, b.Value);
        }

        [Theory]
        [InlineData("")]
        [InlineData("abc123")]
        [InlineData("123-456")]
        public void Barcode_Should_Throw_On_Invalid(string code)
        {
            Assert.Throws<ArgumentException>(() => { Barcode b = code; });
        }

        [Theory]
        [InlineData("0000")]
        [InlineData("9999")]
        public void PIN_Should_Accept_4Digits(string pin)
        {
            PIN p = pin;
            Assert.Equal(pin, p.Value);
        }

        [Theory]
        [InlineData("")]
        [InlineData("12")]
        [InlineData("abcd")]
        [InlineData("12345")]
        public void PIN_Should_Throw_On_Invalid(string pin)
        {
            Assert.Throws<ArgumentException>(() => { PIN p = pin; });
        }
        #endregion

        #region Description
        [Theory]
        [InlineData("This is a valid description text.")]
        [InlineData("          Valid trimmed desc          ")]
        public void Description_Should_Accept_Valid(string desc)
        {
            string trimmed = desc.Trim();
            if (trimmed.Length < 10)
                trimmed = trimmed.PadRight(10, 'x'); // ensure min length for test

            Description d = trimmed;
            Assert.Equal(trimmed, d.Value);
        }

        [Theory]
        [InlineData("")]
        [InlineData("short")]
        [InlineData("    spaces    ")]
        public void Description_Should_Throw_On_TooShort(string desc)
        {
            Assert.Throws<ArgumentException>(() => { Description d = desc; });
        }
        #endregion

        #region Image & QR
        [Theory]
        [InlineData(ValidImageFile)]
        [InlineData("C:\\AirSmileWMS\\TestFiles\\smartboy.jpeg")]
        public void Image_Should_Accept_Valid(string path)
        {
            if (!File.Exists(path)) File.WriteAllText(path, "dummy");

            Image img = path;
            Assert.Equal(path, img.Value);
        }

        [Theory]
        [InlineData("invalid.txt")]
        [InlineData("")]
        [InlineData("C:\\Temp\\..\\hack.jpg")]
        [InlineData("not_existing.png")]
        public void Image_Should_Throw_On_Invalid(string path)
        {
            Assert.Throws<ArgumentException>(() => { Image img = path; });
        }

        [Theory]
        [InlineData(ValidQRFile)]
        [InlineData("C:\\AirSmileWMS\\TestFiles\\test.pdf")]
        public void QR_Should_Accept_Valid(string path)
        {
            if (!File.Exists(path)) File.WriteAllText(path, "dummy");

            QR qr = path;
            Assert.Equal(path, qr.Value);
        }

        [Theory]
        [InlineData("hack.exe")]
        [InlineData("")]
        [InlineData("C:\\Temp\\..\\evil.svg")]
        [InlineData("missing.pdf")]
        public void QR_Should_Throw_On_Invalid(string path)
        {
            Assert.Throws<ArgumentException>(() => { QR qr = path; });
        }
        #endregion

        #region Link
        [Theory]
        [InlineData("https://example.com")]
        [InlineData("http://air-smile.ru")]
        public void Link_Should_Accept_Valid(string url)
        {
            Link link = url;
            Assert.Equal(url, link.Value);
        }

        [Theory]
        [InlineData("")]
        [InlineData("ftp://not-allowed.com")]
        [InlineData("invalid-url")]
        public void Link_Should_Throw_On_Invalid(string url)
        {
            Assert.Throws<ArgumentException>(() => { Link l = url; });
        }
        #endregion
    }
}