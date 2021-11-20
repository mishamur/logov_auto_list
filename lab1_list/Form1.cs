using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

/*
Pазовый платеж за телефонный разговор является структурой с полями: фамилия плательщика, номер телефона,
дата разговора, тариф за минуту разговора, время начала разговора, время окончания разговора.
Поиск и сортировка - по фамилии плательщика, дате разговора. 
Найти все разговоры со временем разговора больше заданного. 
 */


//что осталось сделать

/*
 
 */


namespace lab1_list
{
    public partial class Form1 : Form
    {
        UserList<PhoneTalk> phoneTalks;

        public Form1()
        {
            InitializeComponent();
            this.phoneTalks = new UserList<PhoneTalk>();
            LoadPhoneTalks();
            
        }

        private void UpdateListBox()
        {
         
            listBox1.Items.Clear();

            int count = 0;
            foreach(var value in phoneTalks.ToArray())
            {
                listBox1.Items.Add(value);    
            }

            


        }

        private void SortBySecondName(ref UserList<PhoneTalk> phoneTalks)
        {

            List<PhoneTalk> temp = this.phoneTalks.ToList();
            temp = temp.OrderBy(x => x.SecondName).ToList();
            phoneTalks.Clear();
            foreach(PhoneTalk talk in temp)
            {
                phoneTalks.Add(talk);
            }
            UpdateListBox();
            return;
            
        }

        private void SortByDateTalk(ref UserList<PhoneTalk> phoneTalks)
        {

            List<PhoneTalk> temp = phoneTalks.ToList();
            temp = temp.OrderBy(x => x.DateTalk).ToList();
            phoneTalks.Clear();
            foreach (PhoneTalk talk in temp)
            {
                phoneTalks.Add(talk);
            }
            UpdateListBox();
            return;

        }

        private void LoadPhoneTalks()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\User\\source\\repos\\logov_auto\\lab1_list\\xmltext.xml");

            foreach(XmlNode node in doc.DocumentElement)
            {
                string secondName = node["SecondName"].InnerText;
                long phoneNumber = long.Parse(node["PhoneNumber"].InnerText);
                DateTime dateTalk = DateTime.Parse(node["DateTalk"].InnerText);
                int traficPerMin = int.Parse(node["TraficPerMin"].InnerText);
                TimeSpan begin = TimeSpan.Parse(node["Begin"].InnerText);
                TimeSpan end = TimeSpan.Parse(node["End"].InnerText);
                this.phoneTalks.Add(new PhoneTalk(secondName, phoneNumber, dateTalk, traficPerMin, begin, end));
            }
            UpdateListBox();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTalk = this.dateTimeTalk.Value.Date;

            TimeSpan beginTalk = this.dateTimeBeginTalk.Value.TimeOfDay;
            TimeSpan endTalk = this.dateTimeEndTalk.Value.TimeOfDay;

            int tarif;
            bool tarifIsNumber =  int.TryParse( this.textBoxTarif.Text, out tarif);

            string secondName = this.textBoxSecondName.Text;

            int phoneNumber;
            bool phoneNumberIsNumber = int.TryParse(this.textBoxPhoneNumber.Text, out phoneNumber);


            PhoneTalk phoneTalk = new PhoneTalk();

            try
            {
                if(!tarifIsNumber & !phoneNumberIsNumber)
                {
                    throw new Exception("Некорректный ввод");
                }
                phoneTalk.PhoneNumber = phoneNumber;
                phoneTalk.DateTalk = dateTalk;
                phoneTalk.Begin = beginTalk;
                phoneTalk.End = endTalk;
                phoneTalk.SecondName = secondName;
                phoneTalk.TraficPerMin = tarif;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
                return;
            }


            
            phoneTalks.Add(phoneTalk);

            UpdateListBox();

            int stop = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortBySecondName(ref phoneTalks);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortByDateTalk(ref this.phoneTalks);
            UpdateListBox();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int position = int.Parse(textBoxIndex.Text);
            if(position >= 0 & position < phoneTalks.Count)
            {
                phoneTalks.Delete(position);
                UpdateListBox();
            }
        }

        private void buttonAddAfter_Click(object sender, EventArgs e)
        {
            DateTime dateTalk = this.dateTimeTalk.Value.Date;

            TimeSpan beginTalk = this.dateTimeBeginTalk.Value.TimeOfDay;
            TimeSpan endTalk = this.dateTimeEndTalk.Value.TimeOfDay;

            int tarif;
            bool tarifIsNumber = int.TryParse(this.textBoxTarif.Text, out tarif);

            string secondName = this.textBoxSecondName.Text;

            int phoneNumber;
            bool phoneNumberIsNumber = int.TryParse(this.textBoxPhoneNumber.Text, out phoneNumber);


            PhoneTalk phoneTalk = new PhoneTalk();

            try
            {
                if (!tarifIsNumber & !phoneNumberIsNumber)
                {
                    throw new Exception("Некорректный ввод");
                }
                phoneTalk.PhoneNumber = phoneNumber;
                phoneTalk.DateTalk = dateTalk;
                phoneTalk.Begin = beginTalk;
                phoneTalk.End = endTalk;
                phoneTalk.SecondName = secondName;
                phoneTalk.TraficPerMin = tarif;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            int position = int.Parse(textBoxIndex.Text) + 1;
            if (position >= 0 & position < phoneTalks.Count)
            {
                phoneTalks.Add(phoneTalk, position);
                UpdateListBox();
            }
        }

        private void buttonAddBefore_Click(object sender, EventArgs e)
        {
            DateTime dateTalk = this.dateTimeTalk.Value.Date;

            TimeSpan beginTalk = this.dateTimeBeginTalk.Value.TimeOfDay;
            TimeSpan endTalk = this.dateTimeEndTalk.Value.TimeOfDay;

            int tarif;
            bool tarifIsNumber = int.TryParse(this.textBoxTarif.Text, out tarif);

            string secondName = this.textBoxSecondName.Text;

            int phoneNumber;
            bool phoneNumberIsNumber = int.TryParse(this.textBoxPhoneNumber.Text, out phoneNumber);


            PhoneTalk phoneTalk = new PhoneTalk();

            try
            {
                if (!tarifIsNumber & !phoneNumberIsNumber)
                {
                    throw new Exception("Некорректный ввод");
                }
                phoneTalk.PhoneNumber = phoneNumber;
                phoneTalk.DateTalk = dateTalk;
                phoneTalk.Begin = beginTalk;
                phoneTalk.End = endTalk;
                phoneTalk.SecondName = secondName;
                phoneTalk.TraficPerMin = tarif;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            int position = int.Parse(textBoxIndex.Text);
            if (position >= 0 & position <= phoneTalks.Count)
            {
                phoneTalks.Add(phoneTalk, position);
                UpdateListBox();
            }
        }

        private void buttonSearchSecondName_Click(object sender, EventArgs e)
        {
            string secondName = textBoxSearchName.Text;

            List<PhoneTalk> temp = phoneTalks.ToList();
            temp = temp.Where(x => x.SecondName.Contains(secondName)).ToList();
            listBox1.Items.Clear();
            foreach (PhoneTalk talk in temp)
            {
                listBox1.Items.Add(talk);
            }
           
            return;
        }

        private void buttonSearchDate_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePickerSeacrhDate.Value.Date;

            List<PhoneTalk> temp = phoneTalks.ToList();
            temp = temp.Where(x => x.DateTalk == dateTime).ToList();
            listBox1.Items.Clear();
            foreach (PhoneTalk talk in temp)
            {
                listBox1.Items.Add(talk);
            }

            return;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        
    }
}
