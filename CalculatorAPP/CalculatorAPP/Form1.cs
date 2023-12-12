using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAPP
{
    public partial class Calculator : Form
    {

        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn4;
        private Rectangle btn5;
        private Rectangle btn6;
        private Rectangle btn7;
        private Rectangle btn8;
        private Rectangle btn9;
        private Rectangle btn0;
        private Rectangle boxForInput;
        private Rectangle labelForPreviousInput;

        private Rectangle btnDecimal;
        private Rectangle btnPositiveNegative;
        private Rectangle btnReciprocal;
        private Rectangle btnSquared;
        private Rectangle btnSquareRoot;

        private Rectangle btnModulo;
        private Rectangle btnClearEntered;
        private Rectangle btnClear;

        private Rectangle btnBackspace;
        private Rectangle btnDivide;
        private Rectangle btnMultiply;

        private Rectangle btnAdd;
        private Rectangle btnSubtract;
        private Rectangle btnEquals;

        private Rectangle rtbHistory;

        private Size originalFormSize;


        public Calculator()
        {
            InitializeComponent();
        }

        // define location, width and height of a rectangle that represents a number
        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;

            btn1 = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            btn2 = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            btn3 = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            btn4 = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            btn5 = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            btn6 = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            btn7 = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            btn8 = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            btn9 = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
            btn0 = new Rectangle(button0.Location.X, button0.Location.Y, button0.Width, button0.Height);

            btnDecimal = new Rectangle(buttonDecimal.Location.X, buttonDecimal.Location.Y, buttonDecimal.Width, buttonDecimal.Height);
            btnPositiveNegative = new Rectangle(buttonPosNeg.Location.X, buttonPosNeg.Location.Y, buttonPosNeg.Width, buttonPosNeg.Height);
            btnReciprocal = new Rectangle(buttonReciprocal.Location.X, buttonReciprocal.Location.Y, buttonReciprocal.Width, buttonReciprocal.Height);
            btnSquared = new Rectangle(buttonSquared.Location.X, buttonSquared.Location.Y, buttonSquared.Width, buttonSquared.Height);
            btnSquareRoot = new Rectangle(buttonSquareRoot.Location.X, buttonSquareRoot.Location.Y, buttonSquareRoot.Width, buttonSquareRoot.Height);

            btnModulo = new Rectangle(buttonModulus.Location.X, buttonModulus.Location.Y, buttonModulus.Width, buttonModulus.Height);
            btnClearEntered = new Rectangle(buttonClearEntered.Location.X, buttonClearEntered.Location.Y, buttonClearEntered.Width, buttonClearEntered.Height);
            btnClear = new Rectangle(buttonClear.Location.X, buttonClear.Location.Y, buttonClear.Width, buttonClear.Height);

            btnBackspace = new Rectangle(buttonBackspace.Location.X, buttonBackspace.Location.Y, buttonBackspace.Width, buttonBackspace.Height);
            btnDivide = new Rectangle (buttonDivide.Location.X, buttonDivide.Location.Y, buttonDivide.Width, buttonDivide.Height);
            btnMultiply = new Rectangle(buttonMultiply.Location.X, buttonMultiply.Location.Y, buttonMultiply.Width, buttonMultiply.Height);

            btnAdd = new Rectangle(buttonAdd.Location.X, buttonAdd.Location.Y, buttonAdd.Width, buttonAdd.Height);
            btnSubtract = new Rectangle(buttonSubtract.Location.X, buttonSubtract.Location.Y, buttonSubtract.Width, buttonSubtract.Height);
            btnEquals = new Rectangle(buttonEquals.Location.X, buttonEquals.Location.Y, buttonEquals.Width, buttonEquals.Height);

            rtbHistory = new Rectangle(richTextHistory.Location.X, richTextHistory.Location.Y, richTextHistory.Width, richTextHistory.Height);

            boxForInput = new Rectangle(inputBox.Location.X, inputBox.Location.Y, inputBox.Width, inputBox.Height);
            labelForPreviousInput = new Rectangle(lblPreviousInput.Location.X, lblPreviousInput.Location.Y, lblPreviousInput.Width, lblPreviousInput.Height);

        }


        // new location and size in case of resize        
        private void resizeControl(Rectangle originalControlRectangle, Control control)
        {
            
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(originalControlRectangle.X * xAxis);
            int newYPosition = (int)(originalControlRectangle.Y * yAxis);

            int newWidth = (int)(originalControlRectangle.Width * xAxis);
            int newHeight = (int)(originalControlRectangle.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);


        }


        // pass new values from rectangles to buttons - this makes the resizing work
        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(btn1, button1);
            resizeControl(btn2, button2);
            resizeControl(btn3, button3);
            resizeControl(btn4, button4);
            resizeControl(btn5, button5);
            resizeControl(btn6, button6);
            resizeControl(btn7, button7);
            resizeControl(btn8, button8);
            resizeControl(btn9, button9);
            resizeControl(btn0, button0);

            resizeControl(btnDecimal, buttonDecimal);
            resizeControl(btnPositiveNegative, buttonPosNeg);
            resizeControl(btnReciprocal, buttonReciprocal);
            resizeControl(btnSquared, buttonSquared);
            resizeControl(btnSquareRoot, buttonSquareRoot);

            resizeControl(btnModulo, buttonModulus); 
            resizeControl(btnClearEntered, buttonClearEntered);
            resizeControl(btnClear, buttonClear);

            resizeControl(btnBackspace, buttonBackspace);
            resizeControl(btnDivide, buttonDivide);
            resizeControl(btnMultiply, buttonMultiply);

            resizeControl(btnAdd, buttonAdd);
            resizeControl(btnSubtract, buttonSubtract);
            resizeControl(btnEquals, buttonEquals);

            resizeControl(rtbHistory, richTextHistory);

            resizeControl(boxForInput, inputBox);
            resizeControl(labelForPreviousInput, lblPreviousInput);


        }

        double num1;
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false; 
        string firstNumber, secondNumber;


        // Prevent non number input, limit - to 1, limit . to 1
        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
             if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       

        private void numberButtonClick(object sender, EventArgs e)
        {
            if(isOperationPerformed) inputBox.Clear();

            // button value is button text 
          Button noButton = (Button)sender;
            inputBox.Text = inputBox.Text + noButton.Text;
            isOperationPerformed = false;
        }
      
        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            // button text is operation 
            if (result != 0)
            {
                buttonEquals.PerformClick(); 
                operation = button.Text;
                lblPreviousInput.Text = result + " " + operation;
                isOperationPerformed = true;
            
             }          
                      
            else {
                operation = button.Text;
                result = double.Parse(inputBox.Text);
                lblPreviousInput.Text = result + " " + operation;
                isOperationPerformed = true;

            }

            firstNumber = inputBox.Text;

        }

       
        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            double.TryParse(inputBox.Text, out num1);

        if(num1 > 1)
            {
               result = num1 * -1; 
                inputBox.Text = result.ToString();
            }
        else
            {
                result = num1 * -1;
                inputBox.Text = result.ToString();
            }
            
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
           
            lblPreviousInput.Text = "Input cleared";
            inputBox.Clear();
            num1 = 0;
            result = 0;
            richTextHistory.Clear();
        }

      

        private void buttonClearEntered_Click(object sender, EventArgs e)
        {
            inputBox.Text = null;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
        
            secondNumber = inputBox.Text;   

            switch(operation)
            {
                case "+":
                    inputBox.Text = (result + double.Parse(inputBox.Text)).ToString();
                    break;
                case "-":
                    inputBox.Text = (result - double.Parse(inputBox.Text)).ToString();
                   
                  
                    break;
                case "*":
                    inputBox.Text = (result * double.Parse(inputBox.Text)).ToString();
                   
                   
                    break;
                case "÷":
                    inputBox.Text = (result / double.Parse(inputBox.Text)).ToString();
                 
                    break;
                case "%":
                    inputBox.Text = (result / double.Parse(inputBox.Text) * 100).ToString(); 
                    break;
               
                default:
                    break; 
            }

            result = Double.Parse(inputBox.Text);
          
            lblPreviousInput.Text = "";
            
            
            richTextHistory.AppendText(firstNumber + "  " + operation +  "  " + secondNumber + "\n");
            richTextHistory.AppendText("\n\t" + inputBox.Text + "\n\n");
        }

        private void buttonSquared_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(inputBox.Text); 
            result = num1 * num1;
            lblPreviousInput.Text = result.ToString();
            inputBox.Text = result.ToString();
 
        }

        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(inputBox.Text);
            result = Math.Sqrt(num1);
            lblPreviousInput.Text = result.ToString();
            inputBox.Text = result.ToString();
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if(inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1, 1);
            }


        }
    }
           

}
