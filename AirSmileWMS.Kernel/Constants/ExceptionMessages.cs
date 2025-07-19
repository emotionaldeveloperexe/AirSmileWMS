namespace AirSmileWMS.Kernel.Constants
{
    /// <summary>
    /// Здесь хранятся текста сообщений об ошибках.
    /// </summary>
    public static class ExceptionMessages
    {
        public const string INVALID_NAME        = "Имя, наименование или название не могут быть пустыми.";
        public const string INVALID_SKU         = "Артикул должен быть заполнен.";
        public const string INVALID_IMAGE       = "Некорректный формат изображения.";
        public const string INVALID_BARCODE     = "Некорректный баркод.";
        public const string INVALID_QR          = "Некорректный QR-код.";
        public const string INVALID_PIN         = "PIN-код должен состоять только из 4 цифр.";
        public const string INVALID_LINK        = "Некорректная ссылка.";
        public const string INVALID_DESCRIPTION = "Слишком короткое описание.";
        public const string INVALID_AMOUNT      = "Параметр не может быть отрицательным.";
        public const string INVALID_FILE        = "Файл не найден.";
    }
}
