using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiladorFPGA
{
    public partial class Form1 : Form
    {

        
        private System.IO.StreamWriter file;
        CheckBox[,] boxes = new CheckBox[16, 16];
        int[] R = new int[64];
        int[] G = new int[64];
        int[] B = new int[64];
        int endGlobal = 0;
        int indice = 0;

        string registrador2binario(string s)
        {
            switch (s)
            {
                case "r1":
                    return "00000";
                    break;
                case "r2":
                    return "00001";
                    break;
                case "r3":
                    return "00010";
                    break;
                case "r4":
                    return "00011";
                    break;
                case "r5":
                    return "00100";
                    break;
                case "r6":
                    return "00101";
                    break;
                case "r7":
                    return "00110";
                    break;
                case "r8":
                    return "00111";
                    break;
                case "r9":
                    return "01000";
                    break;
                case "r10":
                    return "01001";
                    break;
                case "r11":
                    return "01010";
                    break;
                case "r12":
                    return "01011";
                    break;
                case "r13":
                    return "01100";
                    break;
                case "r14":
                    return "01101";
                    break;
                case "r15":
                    return "01110";
                    break;
                case "r16":
                    return "01111";
                    break;
                case "r17":
                    return "10000";
                    break;
                case "r18":
                    return "10001";
                    break;
                case "r19":
                    return "10010";
                    break;
                case "r20":
                    return "10011";
                    break;
                case "r21":
                    return "10100";
                    break;
                case "r22":
                    return "10101";
                    break;
                case "r23":
                    return "10110";
                    break;
                case "r24":
                    return "10111";
                    break;
                case "r25":
                    return "11000";
                    break;
                case "r26":
                    return "11001";
                    break;
                case "r27":
                    return "11010";
                    break;
                case "r28":
                    return "11011";
                    break;
                case "r29":
                    return "11100";
                    break;
                case "r30":
                    return "11101";
                    break;
                case "r31":
                    return "11110";
                    break;
                case "r32":
                    return "11111";
                    break;
               
                default:
                    return "erro";
                    break;
            }
        }

        int gerarCodigo(string linha)
        {
            string quebraLinha = "\n";
            file.Write(quebraLinha);
           
            string[] palavras = linha.Split();
            //palavra0 eh opcode
           
            int endLocal = indice + endGlobal;
            file.Write(endLocal.ToString().PadLeft(16, '0'));
            file.Write(" : ");
            endGlobal++;
            switch (palavras[0])
            {
                case "lw":
                    file.Write("001001");
                   

                    break;
                case "sw":
                    file.Write("001010");
                    break;
                case "add":
                    file.Write("010001");
                   
                    string r1 = registrador2binario(palavras[1]);
                    if (r1 == "erro") return 1;
                    file.Write(r1);
                   
                    string r2 = registrador2binario(palavras[2]);
                    if (r2 == "erro") return 1;

                    file.Write(r2);
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                   
                    return 0;
                    break;
                case "sub":
                    file.Write("010010");
                    string r1sub = registrador2binario(palavras[1]);
                    if (r1sub == "erro") return 1;
                    file.Write(r1sub);
                    string r2sub = registrador2binario(palavras[2]);
                    if (r2sub == "erro") return 1;
                    file.Write(r2sub);
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                    return 0;
                    break;
                case "mul":
                    file.Write("010100");
                    string r1mul = registrador2binario(palavras[1]);
                    if (r1mul == "erro") return 1;
                    file.Write(r1mul);
                    string r2mul = registrador2binario(palavras[2]);
                    if (r2mul == "erro") return 1;
                    file.Write(r2mul);
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                    return 0;
                    break;
                case "div":
                    file.Write("010101");
                    string r1div = registrador2binario(palavras[1]);
                    if (r1div == "erro") return 1;
                    file.Write(r1div);
                    string r2div = registrador2binario(palavras[2]);
                    if (r2div == "erro") return 1;
                    file.Write(r2div);
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                    return 0;
                    break;
                case "and":
                    file.Write("100001");
                    string r1and = registrador2binario(palavras[1]);
                    if (r1and == "erro") return 1;
                    file.Write(r1and);
                    string r2and = registrador2binario(palavras[2]);
                    if (r2and == "erro") return 1;
                    file.Write(r2and);
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                    return 0;
                    break;
                case "or":
                    file.Write("100010");
                    string r1or = registrador2binario(palavras[1]);
                    if (r1or == "erro") return 1;
                    file.Write(r1or);
                    string r2or = registrador2binario(palavras[2]);
                    if (r2or == "erro") return 1;
                    file.Write(r2or);
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                    break;
                case "cmp":
                    file.Write("100100");
                    string r1cmp = registrador2binario(palavras[1]);
                    if (r1cmp == "erro") return 1;
                    file.Write(r1cmp);
                    string r2cmp = registrador2binario(palavras[2]);
                    if (r2cmp == "erro") return 1;
                    file.Write(r2cmp);
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                    break;
                case "not":
                    file.Write("100101");
                    string r1not = registrador2binario(palavras[1]);
                    if (r1not == "erro") return 1;
                    file.Write(r1not);
                    file.Write("00000");
                    file.Write(quebraLinha);
                    endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    endGlobal++;
                    file.Write("0".PadLeft(16, '0'));
                    file.Write(quebraLinha);
                    break;
                case "jr":
                    file.Write("101001");
                    break;
                case "brfl":
                    file.Write("101010");
                    break;
                case "call":
                    file.Write("101100");
                    break;
                case "ret":
                    file.Write("101101");
                    break;
                case "nop":
                    file.Write("101110");
                    break;
                default:
                    return 1;
            }
             
            return 0;
        }

        private void iniciarCompilador()
        {
            string quebraLinha = "\n";
            file.Write(quebraLinha);
            file.Write("--iniciando escrita das instrucoes " + indice.ToString());
            apagarTudo();
            file.Write(quebraLinha);
            //inicialmente setar as cores

        }

        public Form1()
        {
            InitializeComponent();
            file = new System.IO.StreamWriter("memoria.mif");
            criarArrayCheckBox();
            iniciarEscrita();


        }

        private void iniciarEscrita()
        {

            file.WriteLine("DEPTH=65536;");
            file.WriteLine("WIDTH=16;");
            file.WriteLine("ADDRESS_RADIX=UNS;");
            file.WriteLine("DATA_RADIX = BIN;");
            file.WriteLine("CONTENT BEGIN");

        }

        private void escreverShape()
        {
            
            string quebraLinha = "\n";
            file.Write(quebraLinha);
            file.Write("--escrevendo shape " + indice.ToString());
            file.Write(quebraLinha);
            for (int i = 0; i < 16; i++) {
                int endLocal = indice + endGlobal;
                file.Write(endLocal.ToString().PadLeft(16, '0'));
                file.Write(" : ");
                endGlobal++;
                for (int j = 0; j < 16; j++)
                {
                    string pixel = returnBoxCondicao(i, j);
                    file.Write(pixel);
                }
                
                file.Write(quebraLinha);
             }
            endGlobal--;


        }

        public void finalizar()
        {
            file.Write("END;");
            file.Close();
        }

        string returnBoxCondicao(int i, int j)
        {
            if (boxes[i, j].Checked) return 0.ToString();
            else return 1.ToString();
        }

        private void apagarTudo()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                    boxes[i, j].Visible = false;
            }
            button1.Visible = false;
            label1.Visible = false;
            button3.Visible = false;
            assemblyCodigo.Visible = true;
        }

        private void zerarCheckBoxes() {
            for (int i = 0; i< 16; i++)
            {
                for (int j = 0; j < 16; j++)
                    boxes[i, j].Checked = false;
            }
        }

        private void criarArrayCheckBox()
        {
            
            boxes[0, 0] = p1_1_;
            boxes[0,1] = p1_2_;

            boxes[0, 2] = p1_3_;
            boxes[0, 3] = p1_4_;
            boxes[0, 4] = p1_5_;
            boxes[0, 5] = p1_6_;
            boxes[0, 6] = p1_7_;
            boxes[0, 7] = p1_8_;
            boxes[0, 8] = p1_9_;
            boxes[0, 9] = p1_10_;
            boxes[0, 10] = p1_11_;
            boxes[0, 11] = p1_12_;
            boxes[0, 12] = p1_13_;
            boxes[0, 13] = p1_14_;
            boxes[0, 14] = p1_15_;
            boxes[0, 15] = p1_16_;
            boxes[1, 15] = p2_16_;
            boxes[1, 14] = p2_15_;
            boxes[1, 13] = p2_14_;
            boxes[1, 12] = p2_13_;
            boxes[1, 11] = p2_12_;
            boxes[1, 10] = p2_11_;
            boxes[1, 9] = p2_10_;
            boxes[1, 8] = p2_9_;
            boxes[1, 7] = p2_8_;
            boxes[1, 6] = p2_7_;
            boxes[1, 5] = p2_6_;
            boxes[1, 4] = p2_5_;
            boxes[1, 3] = p2_4_;
            boxes[1, 2] = p2_3_;
            boxes[1, 1] = p2_2_;
            boxes[1, 0] = p2_1_;
            boxes[2, 15] = p3_16_;
            boxes[2, 14] = p3_15_;
            boxes[2, 13] = p3_14_;
            boxes[2, 12] = p3_13_;
            boxes[2, 11] = p3_12_;
            boxes[2, 10] = p3_11_;
            boxes[2, 9] = p3_10_;
            boxes[2, 8] = p3_9_;
            boxes[2, 7] = p3_8_;
            boxes[2, 6] = p3_7_;
            boxes[2, 5] = p3_6_;
            boxes[2, 4] = p3_5_;
            boxes[2, 3] = p3_4_;
            boxes[2, 2] = p3_3_;
            boxes[2, 1] = p3_2_;
            boxes[2, 0] = p3_1_;
            boxes[3, 15] = p4_16_;
            boxes[3, 14] = p4_15_;
            boxes[3, 13] = p4_14_;
            boxes[3, 12] = p4_13_;
            boxes[3, 11] = p4_12_;
            boxes[3, 10] = p4_11_;
            boxes[3, 9] = p4_10_;
            boxes[3, 8] = p4_9_;
            boxes[3, 7] = p4_8_;
            boxes[3, 6] = p4_7_;
            boxes[3, 5] = p4_6_;
            boxes[3, 4] = p4_5_;
            boxes[3, 3] = p4_4_;
            boxes[3, 2] = p4_3_;
            boxes[3, 1] = p4_2_;
            boxes[3, 0] = p4_1_;
            boxes[4, 15] = p5_16_;
            boxes[4, 14] = p5_15_;
            boxes[4, 13] = p5_14_;
            boxes[4, 12] = p5_13_;
            boxes[4, 11] = p5_12_;
            boxes[4, 10] = p5_11_;
            boxes[4, 9] = p5_10_;
            boxes[4, 8] = p5_9_;
            boxes[4, 7] = p5_8_;
            boxes[4, 6] = p5_7_;
            boxes[4, 5] = p5_6_;
            boxes[4, 4] = p5_5_;
            boxes[4, 3] = p5_4_;
            boxes[4, 2] = p5_3_;
            boxes[4, 1] = p5_2_;
            boxes[4, 0] = p5_1_;
            boxes[5, 15] = p6_16_;
            boxes[5, 14] = p6_15_;
            boxes[5, 13] = p6_14_;
            boxes[5, 12] = p6_13_;
            boxes[5, 11] = p6_12_;
            boxes[5, 10] = p6_11_;
            boxes[5, 9] = p6_10_;
            boxes[5, 8] = p6_9_;
            boxes[5, 7] = p6_8_;
            boxes[5, 6] = p6_7_;
            boxes[5, 5] = p6_6_;
            boxes[5, 4] = p6_5_;
            boxes[5, 3] = p6_4_;
            boxes[5, 2] = p6_3_;
            boxes[5, 1] = p6_2_;
            boxes[5, 0] = p6_1_;
            boxes[6, 15] = p7_16_;
            boxes[6, 14] = p7_15_;
            boxes[6, 13] = p7_14_;
            boxes[6, 12] = p7_13_;
            boxes[6, 11] = p7_12_;
            boxes[6, 10] = p7_11_;
            boxes[6, 9] = p7_10_;
            boxes[6, 8] = p7_9_;
            boxes[6, 7] = p7_8_;
            boxes[6, 6] = p7_7_;
            boxes[6, 5] = p7_6_;
            boxes[6, 4] = p7_5_;
            boxes[6, 3] = p7_4_;
            boxes[6, 2] = p7_3_;
            boxes[6, 1] = p7_2_;
            boxes[6, 0] = p7_1_;
            boxes[7, 15] = p8_16_;
            boxes[7, 14] = p8_15_;
            boxes[7, 13] = p8_14_;
            boxes[7, 12] = p8_13_;
            boxes[7, 11] = p8_12_;
            boxes[7, 10] = p8_11_;
            boxes[7, 9] = p8_10_;
            boxes[7, 8] = p8_9_;
            boxes[7, 7] = p8_8_;
            boxes[7, 6] = p8_7_;
            boxes[7, 5] = p8_6_;
            boxes[7, 4] = p8_5_;
            boxes[7, 3] = p8_4_;
            boxes[7, 2] = p8_3_;
            boxes[7, 1] = p8_2_;
            boxes[7, 0] = p8_1_;
            boxes[15, 15] = p16_16_;
            boxes[15, 14] = p16_15_;
            boxes[15, 13] = p16_14_;
            boxes[15, 12] = p16_13_;
            boxes[15, 11] = p16_12_;
            boxes[15, 10] = p16_11_;
            boxes[15, 9] = p16_10_;
            boxes[15, 8] = p16_9_;
            boxes[15, 7] = p16_8_;
            boxes[15, 6] = p16_7_;
            boxes[15, 5] = p16_6_;
            boxes[15, 4] = p16_5_;
            boxes[15, 3] = p16_4_;
            boxes[15, 2] = p16_3_;
            boxes[15, 1] = p16_2_;
            boxes[15, 0] = p16_1_;
            boxes[14, 15] = p15_16_;
            boxes[14, 14] = p15_15_;
            boxes[14, 13] = p15_14_;
            boxes[14, 12] = p15_13_;
            boxes[14, 11] = p15_12_;
            boxes[14, 10] = p15_11_;
            boxes[14, 9] = p15_10_;
            boxes[14, 8] = p15_9_;
            boxes[14, 7] = p15_8_;
            boxes[14, 6] = p15_7_;
            boxes[14, 5] = p15_6_;
            boxes[14, 4] = p15_5_;
            boxes[14, 3] = p15_4_;
            boxes[14, 2] = p15_3_;
            boxes[14, 1] = p15_2_;
            boxes[14, 0] = p15_1_;
            boxes[13, 15] = p14_16_;
            boxes[13, 14] = p14_15_;
            boxes[13, 13] = p14_14_;
            boxes[13, 12] = p14_13_;
            boxes[13, 11] = p14_12_;
            boxes[13, 10] = p14_11_;
            boxes[13, 9] = p14_10_;
            boxes[13, 8] = p14_9_;
            boxes[13, 7] = p14_8_;
            boxes[13, 6] = p14_7_;
            boxes[13, 5] = p14_6_;
            boxes[13, 4] = p14_5_;
            boxes[13, 3] = p14_4_;
            boxes[13, 2] = p14_3_;
            boxes[13, 1] = p14_2_;
            boxes[13, 0] = p14_1_;
            boxes[12, 15] = p13_16_;
            boxes[12, 14] = p13_15_;
            boxes[12, 13] = p13_14_;
            boxes[12, 12] = p13_13_;
            boxes[12, 11] = p13_12_;
            boxes[12, 10] = p13_11_;
            boxes[12, 9] = p13_10_;
            boxes[12, 8] = p13_9_;
            boxes[12, 7] = p13_8_;
            boxes[12, 6] = p13_7_;
            boxes[12, 5] = p13_6_;
            boxes[12, 4] = p13_5_;
            boxes[12, 3] = p13_4_;
            boxes[12, 2] = p13_3_;
            boxes[12, 1] = p13_2_;
            boxes[12, 0] = p13_1_;
            boxes[11, 15] = p12_16_;
            boxes[11, 14] = p12_15_;
            boxes[11, 13] = p12_14_;
            boxes[11, 12] = p12_13_;
            boxes[11, 11] = p12_12_;
            boxes[11, 10] = p12_11_;
            boxes[11, 9] = p12_10_;
            boxes[11, 8] = p12_9_;
            boxes[11, 7] = p12_8_;
            boxes[11, 6] = p12_7_;
            boxes[11, 5] = p12_6_;
            boxes[11, 4] = p12_5_;
            boxes[11, 3] = p12_4_;
            boxes[11, 2] = p12_3_;
            boxes[11, 1] = p12_2_;
            boxes[11, 0] = p12_1_;
            boxes[10, 15] = p11_16_;
            boxes[10, 14] = p11_15_;
            boxes[10, 13] = p11_14_;
            boxes[10, 12] = p11_13_;
            boxes[10, 11] = p11_12_;
            boxes[10, 10] = p11_11_;
            boxes[10, 9] = p11_10_;
            boxes[10, 8] = p11_9_;
            boxes[10, 7] = p11_8_;
            boxes[10, 6] = p11_7_;
            boxes[10, 5] = p11_6_;
            boxes[10, 4] = p11_5_;
            boxes[10, 3] = p11_4_;
            boxes[10, 2] = p11_3_;
            boxes[10, 1] = p11_2_;
            boxes[10, 0] = p11_1_;
            boxes[9, 15] = p10_16_;
            boxes[9, 14] = p10_15_;
            boxes[9, 13] = p10_14_;
            boxes[9, 12] = p10_13_;
            boxes[9, 11] = p10_12_;
            boxes[9, 10] = p10_11_;
            boxes[9, 9] = p10_10_;
            boxes[9, 8] = p10_9_;
            boxes[9, 7] = p10_8_;
            boxes[9, 6] = p10_7_;
            boxes[9, 5] = p10_6_;
            boxes[9, 4] = p10_5_;
            boxes[9, 3] = p10_4_;
            boxes[9, 2] = p10_3_;
            boxes[9, 1] = p10_2_;
            boxes[9, 0] = p10_1_;
            boxes[8, 15] = p9_16_;
            boxes[8, 14] = p9_15_;
            boxes[8, 12] = p9_13_;
            boxes[8, 11] = p9_12_;
            boxes[8, 10] = p9_11_;
            boxes[8, 9] = p9_10_;
            boxes[8,8] = p9_9_;
            boxes[8, 7] = p9_8_;
            boxes[8, 6] = p9_7_;
            boxes[8, 5] = p9_6_;
            boxes[8, 4] = p9_5_;
            boxes[8, 3] = p9_4_;
            boxes[8, 2] = p9_3_;
            boxes[8, 1] = p9_2_;
            boxes[8, 0] = p9_1_;
            boxes[8, 13] = p9_14_;
       
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox262_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox263_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void fullSprites()
        {
            string quebraLinha = "\n";
            for (int i = indice; i < 64; i++)
            {
                file.Write("--sprites restantes indice"+indice);
                file.Write(quebraLinha);
                for (int j = 0; j < 16; j++)
                {
                    int endLocal = indice + endGlobal;
                    file.Write(endLocal.ToString().PadLeft(16, '0'));
                    file.Write(" : ");
                    file.Write("1111111111111111");
                    endGlobal++;
                    file.Write(quebraLinha);
                }
                endGlobal--;
                indice++;

                R[i - 1] = 0;
                G[i - 1] =0;
                B[i - 1] = 0;
            }
            indice = 64;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if(result == DialogResult.OK) { 
                escreverShape();
                indice++;
                zerarCheckBoxes();
                label1.Text = "Gerando Máscara do Sprite" + indice.ToString();
                //gravando cores
                R[indice-1] = colorDialog1.Color.R;
                G[indice-1] = colorDialog1.Color.G;
                B[indice-1] = colorDialog1.Color.B;
            }
            if (indice == 64)
            {
                iniciarCompilador();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var lines = assemblyCodigo.Text.Split('\n');

            for (int i = 0; i < lines.Length; i++)
            {
                string linha = assemblyCodigo.Lines[i];
               
                if (gerarCodigo(linha) != 0) {
                    MessageBox.Show("Erro no código, try again!");
                   // MessageBox.Show(linha);
                    //erro de compilacao
                    return;
                }
            }
            finalizar();
            MessageBox.Show("Código gerado com sucesso");

        }


        private void button3_Click(object sender, EventArgs e)
        {
            fullSprites();
            iniciarCompilador();
        }
    }
}
