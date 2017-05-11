using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml;

namespace BrushTitle
{
    class Format
    {
        string[][] timu;
        string newTimu;
        int type;

        public string NewTimu
        {
            get { return newTimu; }
        }

        public void format(string txt)
        {

            while (true)
            {

                string[] ti = new string[7];

                if (getASingleChoice(txt, out ti))
                {
                    txt = ti[0];
                    newTimu += "\r\n" + ti[1] + "\r\n" + ti[2] + "\r\n" + ti[3] + "\r\n" + ti[4] + "\r\n" + ti[5] + "\r\n" + ti[6] + "\r\n";

                }
                else break;
            }
        }


        private static bool getASingleChoice(string s, out string[] ti)
        {
            bool isExist = true;

            ti = new string[7];

            int index = 0;
            string line = "";
            string cut = s;//截取后的字符串
            string[] answer = new string[2];
            string optionA = "";
            string optionB = "";
            string optionC = "";
            string optionD = "";

            while (true)
            {
                int[] timuIndex = new int[2] { 0, 0 };
                if (findNextQuestion(cut, out timuIndex))//寻找到题目
                {
                    line = cut.Substring(timuIndex[0], timuIndex[1]); //得到包含题目的字符串
                    if (getAnswer1(line, out answer)) { cut = cut.Remove(0, timuIndex[0] + timuIndex[1]); }//用方法1分开答案和题
                    else if (getAnswer1(line, out answer)) { cut = cut.Remove(0, timuIndex[0] + timuIndex[1]); }//用方法2分开答案和题
                    else //如果得不到答案,此题有错误
                    {
                        cut = cut.Remove(0, timuIndex[1]);//剪切到该题目
                        continue;//寻找下一题
                    }
                }
                else  //寻找不到题目
                {
                    isExist = false; //题目不存在
                    break;
                }


                if (patternOption(cut, 'A', 'B', out index))//得到选项A
                {
                    line = cut.Substring(0, index);
                    optionA = formatOption(line);
                    cut = cut.Remove(0, index);
                }
                else  //如果得不到选项A,此题有错误
                {
                    continue;//寻找下一题
                }

                if (patternOption(cut, 'B', 'C', out index))//得到选项B
                {
                    line = cut.Substring(0, index);
                    optionB = formatOption(line);
                    cut = cut.Remove(0, index);
                    if (patternOption(cut, 'C', 'D', out index))//得到选项C
                    {
                        line = cut.Substring(0, index);
                        optionC = formatOption(line);
                        cut = cut.Remove(0, index);
                        if (patternOption(cut, 'D', '0', out index))//D选项为该题的最后一项
                        {
                            line = cut.Substring(0, index);
                            optionD = formatOption(line);
                            cut = cut.Remove(0, index);
                            break;
                        }
                    }
                    else if (patternOption(cut, 'C', '0', out index))//C选项为该题的最后一项
                    {
                        line = cut.Substring(0, index);
                        optionC = formatOption(line);
                        cut = cut.Remove(0, index);
                        break;
                    }
                }
                else if (patternOption(cut, 'B', '0', out index)) //B选项为该题的最后一项
                {
                    line = cut.Substring(0, index);
                    optionB = formatOption(line);
                    break;
                }

            }

            ti[0] = cut;
            ti[1] = answer[0];
            ti[2] = answer[1];
            ti[3] = optionA;
            ti[4] = optionB;
            ti[5] = optionC;
            ti[6] = optionD;

            return isExist;
        }

        private static bool findNextQuestion(string s, out int[] index)
        {

            s = "\n" + s;//在字符串头加上换行符
            index = new int[2] { 0, 0 };

            Regex re = new Regex(@"\n.*?[（(].*?[)）].*?[　 \n;\t]+A(?![　 ]*[)）])");
            Match m = re.Match(s);
            if (m.Success)
            {
                index[0] = m.Index;
                index[1] = Regex.Match(m.Value, "[　 \n;\t]+A(?![　 ]*[)）])$").Index - 1;//从后开开始找选项A的位置
            }
            else return false;

            return true;
        }

        /// <summary>
        /// 过滤选项
        /// </summary>
        /// <param name="s"></param>
        /// <param name="op"></param>
        /// <param name="isExist"></param>
        /// <returns>返回选项的长度</returns>
        private static bool patternOption(string s, char op, char next, out int index)
        {

            index = 0;
            bool isExist = true;
            string line = "";

            if (next != '0')
            {
                if (op == 'A')//匹配选项A
                {
                    if (isExist = getNextIndex(s, next, out index))
                    {
                        line = s.Substring(0, index);//得到行

                        //判断是否匹配错误
                        if (!Regex.IsMatch(line, "^[　 \n;\t]+A") || (Regex.IsMatch(line, "[　 \n;\t]+B") && Regex.IsMatch(line, "[　 \n;\t]+C")))
                        {
                            isExist = false;
                        }
                    }
                    else isExist = false;
                }
                else if (op == 'B')//匹配选项B
                {
                    if (isExist = getNextIndex(s, next, out index))
                    {
                        line = s.Substring(0, index);//得到行

                        //判断是否匹配错误
                        if (!Regex.IsMatch(line, "^[　 \n;\t]+B") || (Regex.IsMatch(line, "[　 \n;\t]+A") && Regex.IsMatch(line, "[　 \n;\t]+C")))
                        {
                            isExist = false;
                        }

                    }
                    else isExist = false;
                }
                else if (op == 'C')//匹配选项C
                {
                    if (isExist = getNextIndex(s, next, out index))
                    {
                        line = s.Substring(0, index);//得到行

                        //判断是否匹配错误

                        if (!Regex.IsMatch(line, "^[　 \n;\t]+C") || (Regex.IsMatch(line, "[　 \n;\t]+A") && Regex.IsMatch(line, "[　 \n;\t]+B")))
                        {
                            isExist = false;
                        }

                    }
                    else isExist = false;
                }
                else if (op == 'D')//匹配选项D
                {
                    if (isExist = getNextIndex(s, next, out index))
                    {
                        line = s.Substring(0, index);//得到行

                        //判断是否匹配错误
                        if (!Regex.IsMatch(line, "^[　 \n;\t]+D") || (Regex.IsMatch(line, "[　 \n;\t]+A") && Regex.IsMatch(line, "[　 \n;\t]+B")))
                        {
                            isExist = false;
                        }

                    }
                    else isExist = false;
                }
                else if (op == 'E')//匹配选项E
                {
                    if (isExist = getNextIndex(s, next, out index))
                    {
                        line = s.Substring(0, index);//得到行

                        //判断是否匹配错误
                        if (!Regex.IsMatch(line, "^[　 \n;\t]+E") || (Regex.IsMatch(line, "[　 \n;\t]+A") && Regex.IsMatch(line, "[　 \n;\t]+B")))
                        {
                            isExist = false;
                        }

                    }
                    else isExist = false;
                }
                else isExist = false;
            }
            else
            { //如果是匹配最后一个选项

                s += "\n";//防止文本末尾位置匹配不到
                Regex re = new Regex("^[　 \n;\t]+" + op + ".*?\n");
                //Regex re = new Regex("^[　 \n;\t]+" + op + ".*?[　 ]{2,}|^[　 \n;\t]+" + op + ".*?\n|^[　 \n;\t]+" + op + ".*?;|^[　 \n;\t]+" + op + ".*");
                Match m = re.Match(s);
                if (m.Success)
                {
                    index = m.Length - 1;
                }
                else isExist = false;

            }
            return isExist;
        }


        private static bool getNextIndex(string s, char next, out int index)
        {
            bool isRight = true;
            index = 0;

            if (next == 'A')
            {
                Regex re = new Regex("[　 \n;\t]+A(?![　 ]*[)）])");
                Match m = re.Match(s);
                if (m.Success) index = m.Index;
                else isRight = false;
            }
            else if (next == 'B')
            {
                Regex re = new Regex("[　 \n;\t]+B(?![　 ]*[)）])");
                Match m = re.Match(s);
                if (m.Success) index = m.Index;

                else isRight = false;
            }
            else if (next == 'C')
            {
                Regex re = new Regex("[　 \n;\t]+C(?![　 ]*[)）])");
                Match m = re.Match(s);
                if (m.Success) index = m.Index;
                else isRight = false;
            }
            else if (next == 'D')
            {
                Regex re = new Regex("[　 \n;\t]+D(?![　 ]*[)）])");
                Match m = re.Match(s);
                if (m.Success) index = m.Index;
                else isRight = false;
            }
            else if (next == 'E')
            {
                Regex re = new Regex("[　 \n;\t]+E(?![　 ]*[)）])");
                Match m = re.Match(s);
                if (m.Success) index = m.Index;
                else isRight = false;
            }
            else isRight = false;

            return isRight;
        }

        private static string formatOption(string li)//格式化选项
        {
            string line = li;

            Regex re = new Regex("[　 \n;\t]*[A-E]");
            Match m = re.Match(line);
            if (m.Success)
            {
                string op = Regex.Match(m.Value, "[A-E]").Value;//得到选项
                line = line.Remove(0, m.Length);//切掉选项
                line = Regex.Replace(line, "^[　 ]*[、.。;]", "、");
                line = Regex.Replace(line.Replace("\n", ""), "[　 ;\t]+$", "");//去掉换行符和尾部空格等
                line = op + line;
            }
            return line;
        }

        private static bool getAnswer1(string li, out string[] s)
        {
            bool isExist = true;
            string daan = "";
            string line = li;

            Regex re = new Regex("[(（][　 ]*[A-D][　 ]*[[）)]");

            Match m = re.Match(line);//匹配答案
            if (m.Success)
            {
                daan = Regex.Match(m.Value, "[A-D]").Value;
                line = re.Replace(line, "__");//替换括号
                line = Regex.Replace(line.Replace("\n", ""), "^[　 ;\t]+|[　 ;\t]+$", "");//去掉换行符
            }
            else
            {
                isExist = false;
            }
            s = new string[2] { daan, line };
            return isExist;
        }

        private static bool getAnswer2(string li, out string[] s)
        {
            bool isExist = true;
            string daan = "";
            string line = li;

            Regex re = new Regex("(（][　 ].*[）)].*[A-D][　;. ]*$");

            Match m = re.Match(line);//匹配答案
            if (m.Success)
            {
                daan = Regex.Match(m.Value, "[A-D]").Value;
                line = re.Replace(line, "__");//替换括号
                line = Regex.Replace(line.Replace("\n", ""), "^[　 ;\t]+|[　 ;\t]+$", "");//去掉换行符
            }
            else
            {
                isExist = false;
            }
            s = new string[2] { daan, line };
            return isExist;
        }


        //切割

        //添加一题


        //存储
        public void saveAsXml(int type, string name, string s)
        {


        }

    }
}
