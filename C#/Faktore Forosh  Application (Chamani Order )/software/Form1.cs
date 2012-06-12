using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace software
{
    public partial class Form1 : Form
    {
    
        Int64 sumtotal = 0;
      
        public Form1()
        {
            
       
            InitializeComponent();
            radif1.Text = "ردیف";
            sharh1.Text ="نام محصول";
            sumin1.Text = "تعداد موجود در بسته ";
            sum1.Text = "تعداد بسته ";
            totalsum1.Text = " تعداد کل ";
            price1.Text = "قیمت واحد ";
            totalprice1.Text = "جمع کل ";
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Form2 k = new Form2();
            //k.ShowDialog();
            //timer1.Start();
           
            splash s = new splash();
            s.ShowDialog();
            timer1.Start();
            printDocument1.PrinterSettings.DefaultPageSettings.Landscape = true;
            printDocument1.PrinterSettings.DefaultPageSettings.PrinterResolution.Kind = System.Drawing.Printing.PrinterResolutionKind.High;
            printDocument1.PrinterSettings.DefaultPageSettings.PaperSize = printDocument1.PrinterSettings.PaperSizes[1];
    
        }
       private void textBox74_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox82_TextChanged(object sender, EventArgs e)
        {
        }
        /*===============================================================================================*/
        //TEXBOX CODE

        private void sum2_TextChanged(object sender, EventArgs e)
        {
            
            try
            {


                int temp = sum2.SelectionStart;
                sum2.Text = removeAlphabets(sum2.Text);
                sum2.SelectionStart = temp;

                
                if (sumin2.Text == "")
                {
                    sum2.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                
                totalsum2.Text = Convert.ToString(Convert.ToInt64(sumin2.Text) * Convert.ToInt64(sum2.Text));
                
                }
            catch
            { }
           }

        private void price2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price2.SelectionStart;
                price2.Text = removeAlphabets(price2.Text);
                price2.SelectionStart = temp;


                if (sum2.Text == "")
                {
                    price2.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice2.Text = Convert.ToString(Convert.ToInt64(totalsum2.Text) * Convert.ToInt64(price2.Text));
            }
            catch 
            { 
            }

            }

        /*---------------------*/


        private void sum3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum3.SelectionStart;
                sum3.Text = removeAlphabets(sum3.Text);
                sum3.SelectionStart = temp;

                if (sumin3.Text == "")
                {
                    sumin3.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum3.Text = Convert.ToString(Convert.ToInt64(sumin3.Text) * Convert.ToInt64(sum3.Text));
            }
            catch
            {
            }

            }

        private void price3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price3.SelectionStart;
                price3.Text = removeAlphabets(price3.Text);
                price3.SelectionStart = temp;

                if (sum3.Text == "")
                {
                    price3.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice3.Text = Convert.ToString(Convert.ToInt64(totalsum3.Text) * Convert.ToInt64(price3.Text));
            }
            catch
            { 
            }
           }

        /*-------------------------*/


        private void sum4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum4.SelectionStart;
                sum4.Text = removeAlphabets(sum4.Text);
                sum4.SelectionStart = temp;


                if (sumin4.Text == "")
                {
                    sum4.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum4.Text = Convert.ToString(Convert.ToInt64(sumin4.Text) * Convert.ToInt64(sum4.Text));
            }
            catch 
            {
            }
            }

        private void price4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price4.SelectionStart;
                price4.Text = removeAlphabets(price4.Text);
                price4.SelectionStart = temp;


                if (sum4.Text == "")
                {
                    price4.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice4.Text = Convert.ToString(Convert.ToInt64(totalsum4.Text) * Convert.ToInt64(price4.Text));

            }
            catch { }

         }

        /*---------------------------*/
        private void sum5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum5.SelectionStart;
                sum5.Text = removeAlphabets(sum5.Text);
                sum5.SelectionStart = temp;

                if (sumin5.Text == "")
                {
                    sum5.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum5.Text = Convert.ToString(Convert.ToInt64(sumin5.Text) * Convert.ToInt64(sum5.Text));
            }
            catch
            {
            }

        }

        private void price5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price5.SelectionStart;
                price5.Text = removeAlphabets(price5.Text);
                price5.SelectionStart = temp;

                if (sum5.Text == "")
                {
                    price5.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice5.Text = Convert.ToString(Convert.ToInt64(totalsum5.Text) * Convert.ToInt64(price5.Text));

            }
            catch { }

        }



        /*---------------------------*/
          private void sum6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum6.SelectionStart;
                sum6.Text = removeAlphabets(sum6.Text);
                sum6.SelectionStart = temp;

                if (sumin6.Text == "")
                {
                    sum6.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum6.Text = Convert.ToString(Convert.ToInt64(sumin6.Text) * Convert.ToInt64(sum6.Text));
            }
            catch
            {
            }

        }

        private void price6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price6.SelectionStart;
                price6.Text = removeAlphabets(price6.Text);
                price6.SelectionStart = temp;

                if (sum6.Text == "")
                {
                    price6.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice6.Text = Convert.ToString(Convert.ToInt64(totalsum6.Text) * Convert.ToInt64(price6.Text));

            }
            catch { }
        }

    
        /*---------------------------*/
             private void sum7_TextChanged(object sender, EventArgs e)
        {
             try
            {
                int temp = sum7.SelectionStart;
                sum7.Text = removeAlphabets(sum7.Text);
                sum7.SelectionStart = temp;

                if (sumin7.Text == "")
                {
                    sum7.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum7.Text = Convert.ToString(Convert.ToInt64(sumin7.Text) * Convert.ToInt64(sum7.Text));
            }
            catch
            {
            }
        
        }

        private void price7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price7.SelectionStart;
                price7.Text = removeAlphabets(price7.Text);
                price7.SelectionStart = temp;

                if (sum7.Text == "")
                {
                    price7.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice7.Text = Convert.ToString(Convert.ToInt64(totalsum7.Text) * Convert.ToInt64(price7.Text));

            }
            catch { }
        
        }

     
        /*---------------------------*/

        private void sum8_TextChanged(object sender, EventArgs e)
        {
         try
            {
                int temp = sum8.SelectionStart;
                sum8.Text = removeAlphabets(sum8.Text);
                sum8.SelectionStart = temp;

                if (sumin8.Text == "")
                {
                    sum8.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum8.Text = Convert.ToString(Convert.ToInt64(sumin8.Text) * Convert.ToInt64(sum8.Text));
            }
            catch
            {
            }
        }

        private void price8_TextChanged(object sender, EventArgs e)
        {
             try
            {
                int temp = price8.SelectionStart;
                price8.Text = removeAlphabets(price8.Text);
                price8.SelectionStart = temp;

                if (sum8.Text == "")
                {
                    price8.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice8.Text = Convert.ToString(Convert.ToInt64(totalsum8.Text) * Convert.ToInt64(price8.Text));

            }
            catch { }

        
        }

        /*---------------------------*/
         private void sum9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum9.SelectionStart;
                sum9.Text = removeAlphabets(sum9.Text);
                sum9.SelectionStart = temp;

                if (sumin9.Text == "")
                {
                    sum9.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum9.Text = Convert.ToString(Convert.ToInt64(sumin9.Text) * Convert.ToInt64(sum9.Text));
            }
            catch
            {
            }
        
        }

        private void price9_TextChanged(object sender, EventArgs e)
        {
             try
            {
                int temp = price9.SelectionStart;
                price9.Text = removeAlphabets(price9.Text);
                price9.SelectionStart = temp;

                if (sum9.Text == "")
                {
                    price9.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice9.Text = Convert.ToString(Convert.ToInt64(totalsum9.Text) * Convert.ToInt64(price9.Text));

            }
            catch { }
        }


        /*---------------------------*/
        
        private void sum10_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                int temp = sum10.SelectionStart;
                sum10.Text = removeAlphabets(sum10.Text);
                sum10.SelectionStart = temp;

                if (sumin10.Text == "")
                {
                    sum10.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum10.Text = Convert.ToString(Convert.ToInt64(sumin10.Text) * Convert.ToInt64(sum10.Text));
            }
            catch
            {
            }
        
        }

        private void price10_TextChanged(object sender, EventArgs e)
        {
             try
            {
                int temp = price10.SelectionStart;
                price10.Text = removeAlphabets(price10.Text);
                price10.SelectionStart = temp;

                if (sum10.Text == "")
                {
                    price10.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice10.Text = Convert.ToString(Convert.ToInt64(totalsum10.Text) * Convert.ToInt64(price10.Text));

            }
            catch { }

        
        }

    
        /*---------------------------*/

        private void sum11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum11.SelectionStart;
                sum11.Text = removeAlphabets(sum11.Text);
                sum11.SelectionStart = temp;

                if (sumin11.Text == "")
                {
                    sum11.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum11.Text = Convert.ToString(Convert.ToInt64(sumin11.Text) * Convert.ToInt64(sum11.Text));
            }
            catch
            {
            }

        }

        private void price11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price11.SelectionStart;
                price11.Text = removeAlphabets(price11.Text);
                price11.SelectionStart = temp;

                if (sum11.Text == "")
                {
                    price11.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice11.Text = Convert.ToString(Convert.ToInt64(totalsum11.Text) * Convert.ToInt64(price11.Text));

            }
            catch { }

        }
      
        
        
        /*---------------------------*/

        private void sum12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum12.SelectionStart;
                sum12.Text = removeAlphabets(sum12.Text);
                sum12.SelectionStart = temp;

                if (sumin12.Text == "")
                {
                    sum12.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum12.Text = Convert.ToString(Convert.ToInt64(sumin12.Text) * Convert.ToInt64(sum12.Text));
            }
            catch
            {
            }

        }

        private void price12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price12.SelectionStart;
                price12.Text = removeAlphabets(price12.Text);
                price12.SelectionStart = temp;

                if (sum12.Text == "")
                {
                    price12.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice12.Text = Convert.ToString(Convert.ToInt64(totalsum12.Text) * Convert.ToInt64(price12.Text));

            }
            catch { }
        }
        
       
        /*---------------------------*/
        private void sum13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum13.SelectionStart;
                sum13.Text = removeAlphabets(sum13.Text);
                sum13.SelectionStart = temp;

                if (sumin13.Text == "")
                {
                    sum13.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum13.Text = Convert.ToString(Convert.ToInt64(sumin13.Text) * Convert.ToInt64(sum13.Text));
            }
            catch
            {
            }

        }

        private void price13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price13.SelectionStart;
                price13.Text = removeAlphabets(price13.Text);
                price13.SelectionStart = temp;

                if (sum13.Text == "")
                {
                    price13.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice13.Text = Convert.ToString(Convert.ToInt64(totalsum13.Text) * Convert.ToInt64(price13.Text));

            }
            catch { }


        }

        
       
        /*---------------------------*/
        private void sum14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum14.SelectionStart;
                sum14.Text = removeAlphabets(sum14.Text);
                sum14.SelectionStart = temp;

                if (sumin14.Text == "")
                {
                    sum14.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum14.Text = Convert.ToString(Convert.ToInt64(sumin14.Text) * Convert.ToInt64(sum14.Text));
            }
            catch
            {
            }
        }

        private void price14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price14.SelectionStart;
                price14.Text = removeAlphabets(price14.Text);
                price14.SelectionStart = temp;

                if (sum14.Text == "")
                {
                    price14.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice14.Text = Convert.ToString(Convert.ToInt64(totalsum14.Text) * Convert.ToInt64(price14.Text));

            }
            catch { }
        }
        
       
        /*---------------------------*/
        private void sum15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum15.SelectionStart;
                sum15.Text = removeAlphabets(sum15.Text);
                sum15.SelectionStart = temp;

                if (sumin15.Text == "")
                {
                    sum15.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum15.Text = Convert.ToString(Convert.ToInt64(sumin15.Text) * Convert.ToInt64(sum15.Text));
            }
            catch
            {

            }
        }

        private void price15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price15.SelectionStart;
                price15.Text = removeAlphabets(price15.Text);
                price15.SelectionStart = temp;

                if (sum15.Text == "")
                {
                    price15.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice15.Text = Convert.ToString(Convert.ToInt64(totalsum15.Text) * Convert.ToInt64(price15.Text));

            }
            catch { }

        }

      
       
      
        /*---------------------------*/
        private void sum16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum16.SelectionStart;
                sum16.Text = removeAlphabets(sum16.Text);
                sum16.SelectionStart = temp;

                if (sumin16.Text == "")
                {
                    sum16.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum16.Text = Convert.ToString(Convert.ToInt64(sumin16.Text) * Convert.ToInt64(sum16.Text));
            }
            catch
            {
            }

        }

        private void price16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price16.SelectionStart;
                price16.Text = removeAlphabets(price16.Text);
                price16.SelectionStart = temp;

                if (sum16.Text == "")
                {
                    price16.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice16.Text = Convert.ToString(Convert.ToInt64(totalsum16.Text) * Convert.ToInt64(price16.Text));

            }
            catch { }
        }
        
       
        /*---------------------------*/
      /*  private void sum17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum17.SelectionStart;
                sum17.Text = removeAlphabets(sum17.Text);
                sum17.SelectionStart = temp;

                if (sumin17.Text == "")
                {
                    sum17.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum17.Text = Convert.ToString(Convert.ToInt64(sumin17.Text) * Convert.ToInt64(sum17.Text));
            }
            catch
            {
            }
        }

        private void price17_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price17.SelectionStart;
                price17.Text = removeAlphabets(price17.Text);
                price17.SelectionStart = temp;

                if (sum17.Text == "")
                {
                    price17.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice17.Text = Convert.ToString(Convert.ToInt64(totalsum17.Text) * Convert.ToInt64(price17.Text));

            }
            catch { }
        }
        
 */   
        /*---------------------------*/
   /*     private void sum18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum18.SelectionStart;
                sum18.Text = removeAlphabets(sum18.Text);
                sum18.SelectionStart = temp;

                if (sumin18.Text == "")
                {
                    sum18.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum18.Text = Convert.ToString(Convert.ToInt64(sumin18.Text) * Convert.ToInt64(sum18.Text));
            }
            catch
            {
            }
        }

        private void price18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price18.SelectionStart;
                price18.Text = removeAlphabets(price18.Text);
                price18.SelectionStart = temp;

                if (sum18.Text == "")
                {
                    price18.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice18.Text = Convert.ToString(Convert.ToInt64(totalsum18.Text) * Convert.ToInt64(price18.Text));

            }
            catch { }

        }

     */  
        /*---------------------------*/
       /* private void sum19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = sum19.SelectionStart;
                sum19.Text = removeAlphabets(sum19.Text);
                sum19.SelectionStart = temp;

                if (sumin19.Text == "")
                {
                    sum19.Text = "";
                    MessageBox.Show(".لطفا تعداد موجود در بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalsum19.Text = Convert.ToString(Convert.ToInt64(sumin19.Text) * Convert.ToInt64(sum19.Text));
            }
            catch
            {
            }

        }

        private void price19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = price19.SelectionStart;
                price19.Text = removeAlphabets(price19.Text);
                price19.SelectionStart = temp;

                if (sum19.Text == "")
                {
                    price19.Text = "";
                    MessageBox.Show(".لطفا تعداد بسته مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                totalprice19.Text = Convert.ToString(Convert.ToInt64(totalsum19.Text) * Convert.ToInt64(price19.Text));

            }
            catch { }
        }

       */
        /*---------------------------*/

        
        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
            totalprice2.Clear();
            price2.Clear();
            totalsum2.Clear();
            sum2.Clear();
            sumin2.Clear();
            sharh2.Clear();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            totalprice3.Clear();
            price3.Clear();
            totalsum3.Clear();
            sum3.Clear();
            sumin3.Clear();
            sharh3.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            
            totalprice4.Clear();
            price4.Clear();
            totalsum4.Clear();
            sum4.Clear();
            sumin4.Clear();
            sharh4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
            totalprice5.Clear();
            price5.Clear();
            totalsum5.Clear();
            sum5.Clear();
            sumin5.Clear();
            sharh5.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
     
            
            totalprice6.Clear();
            price6.Clear();
            totalsum6.Clear();
            sum6.Clear();
            sumin6.Clear();
            sharh6.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            totalprice7.Clear();
            price7.Clear();
            totalsum7.Clear();
            sum7.Clear();
            sumin7.Clear();
            sharh7.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            totalprice8.Clear();
            price8.Clear();
            totalsum8.Clear();
            sum8.Clear();
            sumin8.Clear();
            sharh8.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
            totalprice9.Clear();
            price9.Clear();
            totalsum9.Clear();
            sum9.Clear();
            sumin9.Clear();
            sharh9.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            totalprice10.Clear();
            price10.Clear();
            totalsum10.Clear();
            sum10.Clear();
            sumin10.Clear();
            sharh10.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            totalprice11.Clear();
            price11.Clear();
            totalsum11.Clear();
            sum11.Clear();
            sumin11.Clear();
            sharh11.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            totalprice12.Clear();
            price12.Clear();
            totalsum12.Clear();
            sum12.Clear();
            sumin12.Clear();
            sharh12.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            totalprice13.Clear();
            price13.Clear();
            totalsum13.Clear();
            sum13.Clear();
            sumin13.Clear();
            sharh13.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            totalprice14.Clear();
            price14.Clear();
            totalsum14.Clear();
            sum14.Clear();
            sumin14.Clear();
            sharh14.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
            totalprice15.Clear();
            price15.Clear();
            totalsum15.Clear();
            sum15.Clear();
            sumin15.Clear();
            sharh15.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            totalprice16.Clear();
            price16.Clear();
            totalsum16.Clear();
            sum16.Clear();
            sumin16.Clear();
            sharh16.Clear();

        }

       /* private void button18_Click(object sender, EventArgs e)
        {
            
            totalprice17.Clear();
            price17.Clear();
            totalsum17.Clear();
            sum17.Clear();
            sumin17.Clear();
            sharh17.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
           
            totalprice18.Clear();
            price18.Clear();
            totalsum18.Clear();
            sum18.Clear();
            sumin18.Clear();
            sharh18.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            totalprice19.Clear();
            price19.Clear();
            totalsum19.Clear();
            sum19.Clear();
            sumin19.Clear();
            sharh19.Clear();
        }
        */

        private void button23_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("آیا شما از ثبت فاکتور جدید مطمئن هستید .در این صورت تمام اطلاعات قبلی از بین خواهد رفت ؟" , "ایجاد فاکتور جدید ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                totalprice2.Clear();
                price2.Clear();
                totalsum2.Clear();
                sum2.Clear();
                sumin2.Clear();
                sharh2.Clear();


                totalprice2.Clear();
                price2.Clear();
                totalsum2.Clear();
                sum2.Clear();
                sumin2.Clear();
                sharh2.Clear();

                totalprice3.Clear();
                price3.Clear();
                totalsum3.Clear();
                sum3.Clear();
                sumin3.Clear();
                sharh3.Clear();

                totalprice4.Clear();
                price4.Clear();
                totalsum4.Clear();
                sum4.Clear();
                sumin4.Clear();
                sharh4.Clear();

                totalprice5.Clear();
                price5.Clear();
                totalsum5.Clear();
                sum5.Clear();
                sumin5.Clear();
                sharh5.Clear();

                totalprice6.Clear();
                price6.Clear();
                totalsum6.Clear();
                sum6.Clear();
                sumin6.Clear();
                sharh6.Clear();

                totalprice7.Clear();
                price7.Clear();
                totalsum7.Clear();
                sum7.Clear();
                sumin7.Clear();
                sharh7.Clear();

                totalprice8.Clear();
                price8.Clear();
                totalsum8.Clear();
                sum8.Clear();
                sumin8.Clear();
                sharh8.Clear();

                totalprice9.Clear();
                price9.Clear();
                totalsum9.Clear();
                sum9.Clear();
                sumin9.Clear();
                sharh9.Clear();

                totalprice10.Clear();
                price10.Clear();
                totalsum10.Clear();
                sum10.Clear();
                sumin10.Clear();
                sharh10.Clear();

                totalprice11.Clear();
                price11.Clear();
                totalsum11.Clear();
                sum11.Clear();
                sumin11.Clear();
                sharh11.Clear();

                totalprice12.Clear();
                price12.Clear();
                totalsum12.Clear();
                sum12.Clear();
                sumin12.Clear();
                sharh12.Clear();

                totalprice13.Clear();
                price13.Clear();
                totalsum13.Clear();
                sum13.Clear();
                sumin13.Clear();
                sharh13.Clear();

                totalprice14.Clear();
                price14.Clear();
                totalsum14.Clear();
                sum14.Clear();
                sumin14.Clear();
                sharh14.Clear();

                totalprice15.Clear();
                price15.Clear();
                totalsum15.Clear();
                sum15.Clear();
                sumin15.Clear();
                sharh15.Clear();

                totalprice16.Clear();
                price16.Clear();
                totalsum16.Clear();
                sum16.Clear();
                sumin16.Clear();
                sharh16.Clear();
                /*totalprice17.Clear();
                price17.Clear();
                totalsum17.Clear();
                sum17.Clear();
                sumin17.Clear();
                sharh17.Clear();

                totalprice18.Clear();
                price18.Clear();
                totalsum18.Clear();
                sum18.Clear();
                sumin18.Clear();
                sharh18.Clear();

                totalprice19.Clear();
                price19.Clear();
                totalsum19.Clear();
                sum19.Clear();
                sumin19.Clear();
                sharh19.Clear();

                */

                radif2.Text = "";
                radif3.Text = "";
                radif4.Text = "";
                radif5.Text = "";
                radif6.Text = "";
                radif7.Text = "";
                radif8.Text = "";
                radif9.Text = "";
                radif10.Text = "";
                radif11.Text = "";
                radif12.Text = "";
                radif13.Text = "";
                radif14.Text = "";
                radif15.Text = "";
                radif16.Text = "";
                /*radif17.Text = "";
                radif18.Text = "";
                radif19.Text = "";*/
                sumtotalbox.Text = "";

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
              /*  checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                */
                //checkBox1.Checked = false;

                /*--------*/


                sharh3.Visible = false;
                sum3.Visible = false;
                sumin3.Visible = false;
                price3.Visible = false;
                totalprice3.Visible = false;
                totalsum3.Visible = false;

                sharh4.Visible = false;
                sum4.Visible = false;
                sumin4.Visible = false;
                price4.Visible = false;
                totalprice4.Visible = false;
                totalsum4.Visible = false;

                sharh5.Visible = false;
                sum5.Visible = false;
                sumin5.Visible = false;
                price5.Visible = false;
                totalprice5.Visible = false;
                totalsum5.Visible = false;

                sharh6.Visible = false;
                sum6.Visible = false;
                sumin6.Visible = false;
                price6.Visible = false;
                totalprice6.Visible = false;
                totalsum6.Visible = false;

                sharh7.Visible = false;
                sum7.Visible = false;
                sumin7.Visible = false;
                price7.Visible = false;
                totalprice7.Visible = false;
                totalsum7.Visible = false;

                sharh8.Visible = false;
                sum8.Visible = false;
                sumin8.Visible = false;
                price8.Visible = false;
                totalprice8.Visible = false;
                totalsum8.Visible = false;

                sharh9.Visible = false;
                sum9.Visible = false;
                sumin9.Visible = false;
                price9.Visible = false;
                totalprice9.Visible = false;
                totalsum9.Visible = false;

                sharh10.Visible = false;
                sum10.Visible = false;
                sumin10.Visible = false;
                price10.Visible = false;
                totalprice10.Visible = false;
                totalsum10.Visible = false;

                sharh11.Visible = false;
                sum11.Visible = false;
                sumin11.Visible = false;
                price11.Visible = false;
                totalprice11.Visible = false;
                totalsum11.Visible = false;

                sharh12.Visible = false;
                sum12.Visible = false;
                sumin12.Visible = false;
                price12.Visible = false;
                totalprice12.Visible = false;
                totalsum12.Visible = false;

                sharh13.Visible = false;
                sum13.Visible = false;
                sumin13.Visible = false;
                price13.Visible = false;
                totalprice13.Visible = false;
                totalsum13.Visible = false;

                sharh14.Visible = false;
                sum14.Visible = false;
                sumin14.Visible = false;
                price14.Visible = false;
                totalprice14.Visible = false;
                totalsum14.Visible = false;

                sharh15.Visible = false;
                sum15.Visible = false;
                sumin15.Visible = false;
                price15.Visible = false;
                totalprice15.Visible = false;
                totalsum15.Visible = false;

                sharh16.Visible = false;
                sum16.Visible = false;
                sumin16.Visible = false;
                price16.Visible = false;
                totalprice16.Visible = false;
                totalsum16.Visible = false;

               /* sharh17.Visible = false;
                sum17.Visible = false;
                sumin17.Visible = false;
                price17.Visible = false;
                totalprice17.Visible = false;
                totalsum17.Visible = false;

                sharh18.Visible = false;
                sum18.Visible = false;
                sumin18.Visible = false;
                price18.Visible = false;
                totalprice18.Visible = false;
                totalsum18.Visible = false;

                sharh19.Visible = false;
                sum19.Visible = false;
                sumin19.Visible = false;
                price19.Visible = false;
                totalprice19.Visible = false;
                totalsum19.Visible = false;

                */



                //button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button15.Visible = false;
                button16.Visible = false;
                button17.Visible = false;
               /* button18.Visible = false;
                button19.Visible = false;
                button20.Visible = false;

                */

                checkBox2.Visible = false;
                radif3.Visible = false;

                checkBox3.Visible = false;
                radif4.Visible = false;

                checkBox4.Visible = false;
                radif5.Visible = false;

                checkBox5.Visible = false;
                radif6.Visible = false;

                checkBox6.Visible = false;
                radif7.Visible = false;

                checkBox7.Visible = false;
                radif8.Visible = false;

                checkBox8.Visible = false;
                radif9.Visible = false;

                checkBox9.Visible = false;
                radif10.Visible = false;

                checkBox10.Visible = false;
                radif11.Visible = false;


                checkBox11.Visible = false;
                radif12.Visible = false;

                checkBox12.Visible = false;
                radif13.Visible = false;

                checkBox13.Visible = false;
                radif14.Visible = false;

                checkBox14.Visible = false;
                radif15.Visible = false;

                checkBox15.Visible = false;
                radif16.Visible = false;

               /* checkBox16.Visible = false;
                radif17.Visible = false;

                checkBox17.Visible = false;
                radif18.Visible = false;

                checkBox18.Visible = false;
                radif19.Visible = false;

                */
            }//if 
            /*--------*/

        }// RESET ALL LINE 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sumtotal = 0;

                if (checkBox1.Checked)
                {
                    if (totalprice2.Text !="")
                    {
                        sumtotal += Convert.ToInt64(totalprice2.Text);
                    }
                }



                if (checkBox2.Checked)
                {
                    if (totalprice3.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice3.Text);
                    }
                }

                if (checkBox3.Checked)
                {
                    if (totalprice4.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice4.Text);
                    }
                 }

                if (checkBox4.Checked)
                {
                    if (totalprice5.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice5.Text);
                    }
                }
                if (checkBox5.Checked)
                {
                    if (totalprice6.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice6.Text);

                    }
                 }


                if (checkBox6.Checked)
                {
                    if (totalprice7.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice7.Text);
                    }
                }


                if (checkBox7.Checked)
                {
                    if (totalprice8.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice8.Text);
                    }
                }

                if (checkBox8.Checked)
                {
                    if (totalprice9.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice9.Text);
                    }
                 }


                if (checkBox9.Checked)
                {
                    if (totalprice10.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice10.Text);
                    }
                 }


                if (checkBox10.Checked)
                {
                    if (totalprice11.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice11.Text);
                    }
                }

                if (checkBox11.Checked)
                {
                    if (totalprice12.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice12.Text);
                    }
                 }
                if (checkBox12.Checked)
                {
                    if (totalprice13.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice13.Text);
                    }
                }


                if (checkBox13.Checked)
                {
                    if (totalprice14.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice14.Text);
                    }
                }
                if (checkBox14.Checked)
                {
                    if (totalprice15.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice15.Text);
                    }
                }

                if (checkBox15.Checked)
                {
                    if (totalprice16.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice16.Text);
                    }
                }

                /*if (checkBox17.Checked)
                {
                    if (totalprice17.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice17.Text);
                    }
                }
                if (checkBox17.Checked)
                {
                    if (totalprice18.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice18.Text);
                    }
                 }

                if (checkBox18.Checked)
                {
                    if (totalprice19.Text != "")
                    {
                        sumtotal += Convert.ToInt64(totalprice19.Text);
                    }
                 }
                */

                sumtotalbox.Text=Convert.ToString(sumtotal);
                
              
                }
            catch { }
                } // TOTALL SUM FOR FAKTOR 

       
        /*==============================================================================*/
        //CHEKBOX

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radif2.Text = "1";
            }
            else
            { radif2.Text = ""; }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                   if (checkBox2.Checked)
            {
                radif3.Text = "2";

            }
            else
            {
                radif3.Text = "";
            }

        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
                   if (checkBox3.Checked)
            {
                radif4.Text = "3";

            }
            else
            {
                radif4.Text = "";
            }

        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
                   if (checkBox4.Checked)
            {
                radif5.Text = "4";

            }
            else
            {
                radif5.Text = "";
            }
        }


         private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           
        
                   if (checkBox5.Checked)
            {
                radif6.Text = "5";

            }
            else
            {
                radif6.Text = "";
            }
        }


         private void checkBox6_CheckedChanged(object sender, EventArgs e)
         {
                    if (checkBox6.Checked)
             {
                 radif7.Text = "6";

             }
             else
             {
                 radif7.Text = "";
             }
         }

         private void checkBox7_CheckedChanged(object sender, EventArgs e)
         {

                    if (checkBox7.Checked)
             {
                 radif8.Text = "7";

             }
             else
             {
                 radif8.Text = "";
             }
         }

         private void checkBox8_CheckedChanged(object sender, EventArgs e)
         {
                    if (checkBox8.Checked)
             {
                 radif9.Text = "8";

             }
             else
             {
                 radif9.Text = "";
             }
         }

         private void checkBox9_CheckedChanged(object sender, EventArgs e)
         {
                    if (checkBox9.Checked)
             {
                 radif10.Text = "9";

             }
             else
             {
                 radif10.Text = "";
             }

         }

         private void checkBox10_CheckedChanged(object sender, EventArgs e)
         {
                    if (checkBox10.Checked)
             {
                 radif11.Text = "10";

             }
             else
             {
                 radif11.Text = "";
             }

         }

         private void checkBox11_CheckedChanged(object sender, EventArgs e)
         {
                    if (checkBox11.Checked)
             {
                 radif12.Text = "11";

             }
             else
             {
                 radif12.Text = "";
             }
         }

         private void checkBox12_CheckedChanged(object sender, EventArgs e)
         {
                    if (checkBox12.Checked)
             {
                 radif13.Text = "12";

             }
             else
             {
                 radif13.Text = "";
             }
         }

         private void checkBox13_CheckedChanged(object sender, EventArgs e)
         {
                    if (checkBox13.Checked)
             {
                 radif14.Text = "13";

             }
             else
             {
                 radif14.Text = "";
             }
         }

         private void checkBox14_CheckedChanged(object sender, EventArgs e)
         {
             if (checkBox14.Checked)
             {
                 radif15.Text = "14";

             }
             else
             {
                 radif15.Text = "";
             }
         }

         private void checkBox15_CheckedChanged(object sender, EventArgs e)
         {

             if (checkBox15.Checked)
             {
                 radif16.Text = "15";

             }
             else
             {
                 radif16.Text = "";
             }
         }

         /*private void checkBox16_CheckedChanged(object sender, EventArgs e)
         {
             if (checkBox16.Checked)
             {
                 radif17.Text = "16";

             }
             else
             {
                 radif17.Text = "";
             }
         }

         private void checkBox17_CheckedChanged(object sender, EventArgs e)
         {
             if (checkBox17.Checked)
             {
                 radif18.Text = "17";

             }
             else
             {
                 radif18.Text = "";
             }
         }

         private void checkBox18_CheckedChanged(object sender, EventArgs e)
         {
             if (checkBox18.Checked)
             {
                 radif19.Text = "18";

             }
             else
             {
                 radif19.Text = "";
             }

         }*/


        /*================================================================================*/


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*================================================================================*/

        private void sumin2_TextChanged(object sender, EventArgs e)
        {
            int temp=sumin2.SelectionStart;
            sumin2.Text = removeAlphabets(sumin2.Text);
            sumin2.SelectionStart = temp;

            if (sharh2.Text == "")
            {
                sumin2.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
               
           
            
        }

        private void sharh2_TextChanged(object sender, EventArgs e)
        {

            checkBox1.Checked = true;

        }

        private void sharh3_TextChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void sumin3_TextChanged(object sender, EventArgs e)
        {
            int temp=sumin3.SelectionStart;
            sumin3.Text = removeAlphabets(sumin3.Text);
            sumin3.SelectionStart = temp;

            if (sharh3.Text == "")
            {
                sumin3.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void sharh4_TextChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void sumin4_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin4.SelectionStart;
            sumin4.Text = removeAlphabets(sumin4.Text);
            sumin4.SelectionStart = temp;


            if (sharh4.Text == "")
            {
                sumin4.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void sharh5_TextChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = true;
       }

        private void sumin5_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin5.SelectionStart;
            sumin5.Text = removeAlphabets(sumin5.Text);
            sumin5.SelectionStart = temp;

            if (sharh5.Text == "")
            {
                sumin5.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void sharh6_TextChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = true;

        }

        private void sumin6_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin6.SelectionStart;
            sumin6.Text = removeAlphabets(sumin6.Text);
            sumin6.SelectionStart = temp;

            if (sharh6.Text == "")
            {
                sumin6.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void sharh7_TextChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = true;
        }

        private void sumin7_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin7.SelectionStart;
            sumin7.Text = removeAlphabets(sumin7.Text);
            sumin7.SelectionStart = temp;

                if (sharh7.Text == "")
            {
                sumin7.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh8_TextChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = true;

        }

        private void sumin8_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin8.SelectionStart;
            sumin8.Text = removeAlphabets(sumin8.Text);
            sumin8.SelectionStart = temp;

               if (sharh8.Text == "")
            {
                sumin8.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh9_TextChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = true;
        }

        private void sumin9_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin9.SelectionStart;
            sumin9.Text = removeAlphabets(sumin9.Text);
            sumin9.SelectionStart = temp;

               if (sharh9.Text == "")
            {
                sumin9.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh10_TextChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = true;
        }

        private void sumin10_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin10.SelectionStart;
            sumin10.Text = removeAlphabets(sumin10.Text);
            sumin10.SelectionStart = temp;

               if (sharh10.Text == "")
            {
                sumin10.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh11_TextChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = true;
            if (radif11.Text != "10")
            {
                sharh11.Text = "";
                MessageBox.Show(".لطفا چک باکس ردیف مربوطه را تیک بزنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            } 
        }

        private void sumin11_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin11.SelectionStart;
            sumin11.Text = removeAlphabets(sumin11.Text);
            sumin11.SelectionStart = temp;

               if (sharh11.Text == "")
            {
                sumin11.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void sharh12_TextChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = true;
        }

        private void sumin12_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin12.SelectionStart;
            sumin12.Text = removeAlphabets(sumin12.Text);
            sumin12.SelectionStart = temp;

               if (sharh12.Text == "")
            {
                sumin12.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void sharh13_TextChanged(object sender, EventArgs e)
        {

            checkBox12.Checked = true;

        }

        private void sumin13_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin13.SelectionStart;
            sumin13.Text = removeAlphabets(sumin13.Text);
            sumin13.SelectionStart = temp;

               if (sharh13.Text == "")
            {
                sumin13.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh14_TextChanged(object sender, EventArgs e)
        {
            checkBox13.Checked = true;
        }

        private void sumin14_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin14.SelectionStart;
            sumin14.Text = removeAlphabets(sumin14.Text);
            sumin14.SelectionStart = temp;

               if (sharh14.Text == "")
            {
                sumin14.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh15_TextChanged(object sender, EventArgs e)
        {
            checkBox14.Checked = true;
        }

        private void sumin15_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin15.SelectionStart;
            sumin15.Text = removeAlphabets(sumin15.Text);
            sumin15.SelectionStart = temp;

               if (sharh15.Text == "")
            {
                sumin15.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh16_TextChanged(object sender, EventArgs e)
        {
            checkBox15.Checked = true;
            if (radif16.Text != "15")
            {
                sharh16.Text = "";
                MessageBox.Show(".لطفا چک باکس ردیف مربوطه را تیک بزنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void sumin16_TextChanged(object sender, EventArgs e)
        {

            int temp = sumin16.SelectionStart;
            sumin16.Text = removeAlphabets(sumin16.Text);
            sumin16.SelectionStart = temp;

               if (sharh16.Text == "")
            {
                sumin16.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

   /*     private void sharh17_TextChanged(object sender, EventArgs e)
        {
            checkBox16.Checked = true;


        }

        private void sumin17_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin17.SelectionStart;
            sumin17.Text = removeAlphabets(sumin17.Text);
            sumin17.SelectionStart = temp;

               if (sharh17.Text == "")
            {
                sumin17.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh18_TextChanged(object sender, EventArgs e)
        {
            checkBox17.Checked = true;
        }

        private void sumin18_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin18.SelectionStart;
            sumin18.Text = removeAlphabets(sumin18.Text);
            sumin18.SelectionStart = temp;
               if (sharh18.Text == "")
            {
                sumin18.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void sharh19_TextChanged(object sender, EventArgs e)
        {
            checkBox18.Checked = true;
        }

        private void sumin19_TextChanged(object sender, EventArgs e)
        {
            int temp = sumin19.SelectionStart;
            sumin19.Text = removeAlphabets(sumin19.Text);
            sumin19.SelectionStart = temp;

               if (sharh19.Text == "")
            {
                sumin19.Text = "";
                MessageBox.Show(".لطفا نام محصول مربوط به این ردیف را وارد کنید ", "اخطار ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }*/


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sharh1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalprice2_TextChanged(object sender, EventArgs e)
        {
            sharh3.Visible = true;
            sum3.Visible = true;
            sumin3.Visible = true;
            price3.Visible = true;
            totalprice3.Visible = true;
            totalsum3.Visible = true;
            button4.Visible = true;
            checkBox2.Visible = true;
            radif3.Visible = true;
        }

        private void totalprice3_TextChanged(object sender, EventArgs e)
        {
            sharh4.Visible = true;
            sum4.Visible = true;
            sumin4.Visible = true;
            price4.Visible = true;
            totalprice4.Visible = true;
            totalsum4.Visible = true;
            button5.Visible = true;
            checkBox3.Visible = true;
            radif4.Visible = true;
        }

        private void totalprice4_TextChanged(object sender, EventArgs e)
        {
            sharh5.Visible = true;
            sum5.Visible = true;
            sumin5.Visible = true;
            price5.Visible = true;
            totalprice5.Visible = true;
            totalsum5.Visible = true;
            button6.Visible = true;
            checkBox4.Visible = true;
            radif5.Visible = true;
        }

        private void totalprice5_TextChanged(object sender, EventArgs e)
        {
            sharh6.Visible = true;
            sum6.Visible = true;
            sumin6.Visible = true;
            price6.Visible = true;
            totalprice6.Visible = true;
            totalsum6.Visible = true;
            button7.Visible = true;
            checkBox5.Visible = true;
            radif6.Visible = true;
        }

        private void totalprice6_TextChanged(object sender, EventArgs e)
        {
            sharh7.Visible = true;
            sum7.Visible = true;
            sumin7.Visible = true;
            price7.Visible = true;
            totalprice7.Visible = true;
            totalsum7.Visible = true;
            button8.Visible = true;
            checkBox6.Visible = true;
            radif7.Visible = true;
        }

        private void totalprice7_TextChanged(object sender, EventArgs e)
        {
            sharh8.Visible = true;
            sum8.Visible = true;
            sumin8.Visible = true;
            price8.Visible = true;
            totalprice8.Visible = true;
            totalsum8.Visible = true;
            button9.Visible = true;
            checkBox7.Visible = true;
            radif8.Visible = true;
        }

        private void totalprice8_TextChanged(object sender, EventArgs e)
        {
            sharh9.Visible = true;
            sum9.Visible = true;
            sumin9.Visible = true;
            price9.Visible = true;
            totalprice9.Visible = true;
            totalsum9.Visible = true;
            button10.Visible = true;
            checkBox8.Visible = true;
            radif9.Visible = true;
        }

        private void totalprice9_TextChanged(object sender, EventArgs e)
        {
            sharh10.Visible = true;
            sum10.Visible = true;
            sumin10.Visible = true;
            price10.Visible = true;
            totalprice10.Visible = true;
            totalsum10.Visible = true;
            button11.Visible = true;
            checkBox9.Visible = true;
            radif10.Visible = true;
        }

        private void totalprice10_TextChanged(object sender, EventArgs e)
        {
            sharh11.Visible = true;
            sum11.Visible = true;
            sumin11.Visible = true;
            price11.Visible = true;
            totalprice11.Visible = true;
            totalsum11.Visible = true;
            button12.Visible = true;
            checkBox10.Visible = true;
            radif11.Visible = true;
        }

        private void totalprice11_TextChanged(object sender, EventArgs e)
        {
            sharh12.Visible = true;
            sum12.Visible = true;
            sumin12.Visible = true;
            price12.Visible = true;
            totalprice12.Visible = true;
            totalsum12.Visible = true;
            button13.Visible = true;
            checkBox11.Visible = true;
            radif12.Visible = true;

        }


        private void totalprice12_TextChanged(object sender, EventArgs e)
        {
            sharh13.Visible = true;
            sum13.Visible = true;
            sumin13.Visible = true;
            price13.Visible = true;
            totalprice13.Visible = true;
            totalsum13.Visible = true;
            button14.Visible = true;
            checkBox12.Visible = true;
            radif13.Visible = true;

        }

        private void totalprice13_TextChanged(object sender, EventArgs e)
        {
            sharh14.Visible = true;
            sum14.Visible = true;
            sumin14.Visible = true;
            price14.Visible = true;
            totalprice14.Visible = true;
            totalsum14.Visible = true;
            button15.Visible = true;
            checkBox13.Visible = true;
            radif14.Visible = true;

        }

        private void totalprice14_TextChanged(object sender, EventArgs e)
        {
            sharh15.Visible = true;
            sum15.Visible = true;
            sumin15.Visible = true;
            price15.Visible = true;
            totalprice15.Visible = true;
            totalsum15.Visible = true;
            button16.Visible = true;
            checkBox14.Visible = true;
            radif15.Visible = true;

        }

        private void totalprice15_TextChanged(object sender, EventArgs e)
        {
            sharh16.Visible = true;
            sum16.Visible = true;
            sumin16.Visible = true;
            price16.Visible = true;
            totalprice16.Visible = true;
            totalsum16.Visible = true;
            button17.Visible = true;
            checkBox15.Visible = true;
            radif16.Visible = true;

        }

    /*   private void totalprice16_TextChanged(object sender, EventArgs e)
        {
            sharh17.Visible = true;
            sum17.Visible = true;
            sumin17.Visible = true;
            price17.Visible = true;
            totalprice17.Visible = true;
            totalsum17.Visible = true;
            button18.Visible = true;
            checkBox16.Visible = true;
            radif17.Visible = true;

        }

        private void totalprice17_TextChanged(object sender, EventArgs e)
        {
            sharh18.Visible = true;
            sum18.Visible = true;
            sumin18.Visible = true;
            price18.Visible = true;
            totalprice18.Visible = true;
            totalsum18.Visible = true;
            button19.Visible = true;
            checkBox17.Visible = true;
            radif18.Visible = true;

        }


        private void totalprice18_TextChanged(object sender, EventArgs e)
        {
            sharh19.Visible = true;
            sum19.Visible = true;
            sumin19.Visible = true;
            price19.Visible = true;
            totalprice19.Visible = true;
            totalsum19.Visible = true;
            button20.Visible = true;
            checkBox18.Visible = true;
            radif19.Visible = true;

        }

        */
        private void sumtotalbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
            
        } 

       private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            DateTime d = GH_Date.GtoH(DateTime.Now);
            time.Text += "-" + d.Year.ToString() + "/" + d.Month.ToString() + "/" + d.Day.ToString() +"-"+GH_Date.getHDayOfWeek(DateTime.Now);


        }
        


        //methods
        private string removeAlphabets(string text) 
        {
            for (int i = 0; i < text.Length; i++)
            {
                char ch = Convert.ToChar(text.Substring(i, 1));
                if (ch < '0' || ch > '9')
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }
            return text;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap b = new Bitmap(1178, 777);
            button23.Visible = button2.Visible = button24.Visible = button25.Visible = label5.Visible= false;
            button4.Visible = button5.Visible = button6.Visible = button7.Visible = button8.Visible = button9.Visible = button10.Visible = button11.Visible = button12.Visible = false;
            button13.Visible = button14.Visible = button15.Visible = button16.Visible = button17.Visible = button3.Visible=false; 
                //button18.Visible = button19.Visible =button20.Visible=false;
 
            label3.Visible=true;
            rial.Visible = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DrawToBitmap(b, this.DisplayRectangle);
             button3.Visible=true;
            if(checkBox2.Checked)
           // button4.Visible = true;
            
            if (checkBox3.Checked)
            button5.Visible = true;
            
            if (checkBox4.Checked)
            button6.Visible = true;
            
            if (checkBox5.Checked)
            button7.Visible = true;
            
            if (checkBox6.Checked)
            button8.Visible = true;
            
            if (checkBox7.Checked)
            button9.Visible = true;
            
            if (checkBox8.Checked)
            button10.Visible = true;
            
            if (checkBox9.Checked)
            button11.Visible = true;
            
            if (checkBox10.Checked)
            button12.Visible = true;
            
            if (checkBox11.Checked)
            button13.Visible = true;

            if (checkBox12.Checked)
            button14.Visible = true;
            
            if (checkBox13.Checked)
            button15.Visible = true;
            
            if (checkBox14.Checked)
            button16.Visible = true;
            
            if (checkBox15.Checked)
            button17.Visible = true;
            
           /* if (checkBox16.Checked)
            button18.Visible = true;
            
            if (checkBox17.Checked)
            button19.Visible = true;
            
            if (checkBox18.Checked)
            button20.Visible = true;
            */
            rial.Visible = false;
            
          
 

            label3.Visible = false;
            button23.Visible = button2.Visible = button24.Visible = button25.Visible = label5.Visible = true;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            Image img = (Image)b;
            e.Graphics.DrawImage(img, new Point(40,20));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            
            printPreviewDialog1.Show();
            printPreviewDialog1.Activate();
          }

        private void printPreviewDialog1_Shown(object sender, EventArgs e)
        {
            printPreviewDialog1.Activate();
        }
    }
    }
