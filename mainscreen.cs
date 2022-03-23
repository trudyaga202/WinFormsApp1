namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        String[] imagelist = new string[]
{"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg"};
        private int index;
        Country[] countries = new Country[5];

         public Form1()
        {
            InitializeComponent();
            Country country = new Country();
            country.set("ARG", "Argentina");
            countries[0] = country;
            country.set("AT", "Austria");
            countries[0] = country;
            country.set("AUS", "Australia");
            countries[0] = country;
            country.set("BI", "Bosnia");
            countries[0] = country;
            country.set("BIH", "Bosnia Herzegovina");
            countries[0] = country;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[0]);
            pictureBox3.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[1]);
            pictureBox4.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[2]);
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form4 = new AdminLogin();
            form4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

           

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { 
            index++;
            if (index > 3) index = 3;
            pictureBox2.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[index + 0]);
            pictureBox3.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[index + 1]);
            pictureBox4.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[index + 2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 1) index = 0;
            pictureBox2.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[index + 0]);
            pictureBox3.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[index + 1]);
            pictureBox4.Load("C:/Users/пп/Desktop/программирование на высших языках/Клон/imagelist/" + imagelist[index + 2]);
        }
    }
}