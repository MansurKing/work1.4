using System;

namespace work1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int imagesInAlbum = 52;
            int groupOfImages = 3;

            int fullRowsCount = imagesInAlbum / groupOfImages;
            int remainsImagesCount = imagesInAlbum % groupOfImages;

            Console.WriteLine($"Заполненных рядов в сумме получилось = {fullRowsCount}");
            Console.WriteLine($"Оставшееся кол-во картинок, которые не вошли в ряд = {remainsImagesCount}");
        }
    }
}
