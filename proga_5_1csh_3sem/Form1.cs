using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace proga_5_1csh_3sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузить первое изображение из файла
            // Используется класс Bitmap для загрузки изображения из файла
            Bitmap image1 = new Bitmap("C:\\Users\\Vladislav\\Documents\\qt proect\\proga_5_1_spl_3sem\\panda.jpeg");

            // Создать PictureBox для первого изображения
            // Используется класс PictureBox для отображения изображения
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = image1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = image1.Size;
            this.Controls.Add(pictureBox1);

            // Загрузить второе изображение из файла
            // Используется класс Bitmap для загрузки изображения из файла
            Bitmap image2 = new Bitmap("C:\\Users\\Vladislav\\Documents\\qt proect\\proga_5_1_spl_3sem\\panda.jpeg");

            // Создать прямоугольник для второй части изображения
            // Используется класс Rectangle для создания прямоугольника
            Rectangle rect = new Rectangle(200, 200, 300, 300);

            // Копировать часть второго изображения в прямоугольник
            // Используется класс Bitmap для создания новой картинки
            // Используется класс Graphics для копирования части изображения
            Bitmap part2 = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(part2))
            {
                g.DrawImage(image2, 0, 0, rect, GraphicsUnit.Pixel);
            }

            // Создать PictureBox для второй части изображения
            // Используется класс PictureBox для отображения изображения
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Image = part2;
            pictureBox2.Location = new Point(100, 100);
            pictureBox2.Size = part2.Size;
            this.Controls.Add(pictureBox2);

            // Переместить второе изображение на передний план
            pictureBox2.BringToFront();

            // Установить размеры формы
            // Используется свойство Size для установки размеров формы
            this.Size = new Size(image1.Width, image1.Height);
        }
    }
}