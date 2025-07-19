using System;
using System.IO;
using System.Text.RegularExpressions;
using AirSmileWMS.Kernel.Constants;

namespace AirSmileWMS.Kernel.Services
{
    /// <summary>
    /// Здесь собрана вся логика валидаций бизнес типов.
    /// </summary>
    internal static class Validate
    {
        /// <summary>
        /// Не может быть null, пустой строкой или состоять только из пробелов.
        /// </summary>
        public static string Name(string name) => ThrowIfNullOrWhiteSpace(name, ExceptionMessages.INVALID_NAME);

        /// <summary>
        /// Должен быть заполнен. Нет проверок на формат т. к. у каждого магазина свои непредсказуемые артикулы.
        /// </summary>
        public static string SKU(string sku) => ThrowIfNullOrWhiteSpace(sku, ExceptionMessages.INVALID_SKU);

        // Логика проверки на заполненность.
        private static string ThrowIfNullOrWhiteSpace(string value, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(exceptionMessage);

            return value.Trim();
        }

        /// <summary>
        /// Должен состоять только из цифр.
        /// </summary>
        public static string Barcode(string barcode) => ThrowIfInvalidFormat(barcode, Format.Barcode, ExceptionMessages.INVALID_BARCODE);

        /// <summary>
        /// Должен состоять только из 4 цифр.
        /// </summary>
        public static string PIN(string pin) => ThrowIfInvalidFormat(pin, Format.PIN, ExceptionMessages.INVALID_PIN);

        // Логика проверки формата.
        private static string ThrowIfInvalidFormat(string value, Regex format, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(value) || !format.IsMatch(value))
                throw new ArgumentException(exceptionMessage);

            return value;
        }

        /// <summary>
        /// Файл изображения должен быть корректного расширения.
        /// </summary>
        public static string Image(string path) => ThrowIfInvalidFilePath(ThrowIfInvalidFormat(path?.Trim() ?? string.Empty, Format.Image, ExceptionMessages.INVALID_IMAGE));

        /// <summary>
        /// Файл с QR-кодом должен быть корректного расширения.
        /// </summary>
        public static string QR(string path) => ThrowIfInvalidFilePath(ThrowIfInvalidFormat(path?.Trim() ?? string.Empty, Format.QR, ExceptionMessages.INVALID_QR));

        // Логика проверки файла.
        private static string ThrowIfInvalidFilePath(string path)
        {
            string fileName = Path.GetFileName(ThrowIfNullOrWhiteSpace(path, ExceptionMessages.INVALID_FILE));

            if (string.IsNullOrEmpty(fileName) || path.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                throw new ArgumentException(ExceptionMessages.INVALID_FILE);

            // Запрещаем выход за пределы каталога (../ или ..\)
            if (path.Contains(".."))
                throw new ArgumentException(ExceptionMessages.INVALID_FILE);

            // Проверяем, что файл реально существует
            if (!File.Exists(path))
                throw new ArgumentException(ExceptionMessages.INVALID_FILE);

            return path;
        }

        /// <summary>
        /// Должна быть корректной.
        /// </summary>
        public static string Link(string url) 
        {
            url = ThrowIfNullOrWhiteSpace(url, ExceptionMessages.INVALID_LINK);

            if (!Uri.TryCreate(url, UriKind.Absolute, out var uriResult) || !(uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                throw new ArgumentException(ExceptionMessages.INVALID_LINK);

            return url;
        }

        /// <summary>
        /// Не может быть меньше 10 символов.
        /// </summary>
        public static string Description(string description)
        {
            description = description.Trim();

            if (description.Length < 10)
                throw new ArgumentException(ExceptionMessages.INVALID_DESCRIPTION);

            return description;
        }

        /// <summary>
        /// Проверка, что число не отрицательное.
        /// </summary>
        public static int Amount(int amount)
        {
            if (amount < 0)
                throw new ArgumentException(ExceptionMessages.INVALID_AMOUNT);

            return amount;
        }
    }
}
