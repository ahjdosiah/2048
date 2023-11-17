using System.Media;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace 课设
{
    public partial class Form1 : Form
    {
        public int Score;
        public int Best;
        public int backScore;
        public string option;
        private SoundPlayer player;
        private bool play;

        private string[] rank;
        private string[] pirate;

        public int[,] map;//游戏界面
        public int[,] cp;//上一步的游戏
        private bool flag;//配合move()函数
        private move_player move_key;
        public Random Random { get; } = new Random();
        public Form1()
        {
            map = new int[4, 4] { { 0, 0, 0, 0 },
                                  { 0, 0, 0, 0 },
                                  { 0, 0, 0, 0 },
                                  { 0, 0, 0, 0 } };
            rank = new string[12] { "", "青铜", "白银", "黄金", "铂金", "钻石", "星耀", "王者", "无双", "荣耀", "无敌", "赢" };
            pirate = new string[12] { "", "见习", "船员", "副手", "船长", "伟大航路", "极恶世代", "新世界", "七武海", "五皇", "四皇", "海贼王" };
            cp = new int[4, 4];
            copy();

            player = new SoundPlayer();
            play = true;
            option = string.Empty;
            flag = false;
            backScore = 0;
            Score = 0;
            Best = 0;

            InitializeComponent();
            type.DropDownStyle = ComboBoxStyle.DropDownList;
            Display(Box, warn, type);
        }
        private void copy()//cp == map
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cp[i, j] = map[i, j];
                }
            }
        }
        private bool Equel()//判断cp[]和map[]是否相等，用于判断是否进行移动
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (cp[i, j] != map[i, j])
                        return false;
                }
            }
            return true;
        }
        private void PutNewValue()//在游戏中随机位置创造一个值
        {
            int value;

            value = Random.Next(0, 100) < 80 ? 512 : 1024;//设置2和4出现的概率
            int i = Random.Next(0, 4);
            int j = Random.Next(0, 4);

            while (true)//循环到map=0为止
            {
                if (map[i, j] == 0)
                {
                    map[i, j] = value;
                    break;
                }
                else
                {
                    i = Random.Next(0, 4);
                    j = Random.Next(0, 4);
                }
            }
        }
        private void Display(GroupBox Box, Label warn, ComboBox type)//绘制游戏
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int Num = i * 4 + j + 1;
                    string str = $"box{Num}";
                    foreach (Control ctrl in Box.Controls)
                    {
                        if (ctrl.Name == str)
                        {
                            Label box = (Label)ctrl;
                            if (map[i,j] == 2048)
                            {
                                player = new SoundPlayer("E:\\school\\learning\\C#\\2048\\课设\\wav\\win.wav");
                                player.Play();
                                player = new SoundPlayer("E:\\school\\learning\\C#\\2048\\课设\\wav\\attack1.wav");
                            }
                                
                            switch (type.Text)//根据ComboBox的选择来显示
                            {
                                case "数字":
                                    box.Text = (map[i, j] != 0) ? map[i, j].ToString() : "";
                                    break;
                                case "段位":
                                    switch (map[i, j])
                                    {
                                        case 0:    box.Text = rank[0];  break;
                                        case 2:    box.Text = rank[1];  break;
                                        case 4:    box.Text = rank[2];  break;
                                        case 8:    box.Text = rank[3];  break;
                                        case 16:   box.Text = rank[4];  break;
                                        case 32:   box.Text = rank[5];  break;
                                        case 64:   box.Text = rank[6];  break;
                                        case 128:  box.Text = rank[7];  break;
                                        case 256:  box.Text = rank[8];  break;
                                        case 512:  box.Text = rank[9];  break;
                                        case 1024: box.Text = rank[10]; break;
                                        case 2048: box.Text = rank[11]; break;
                                        default:
                                            box.Text = map[i, j].ToString();
                                            warn.Text = "Win"; 
                                            break;
                                    }
                                    break;
                                case "海贼王":
                                    switch (map[i, j])
                                    {
                                        case 0:    box.Text = pirate[0];  break;
                                        case 2:    box.Text = pirate[1];  break;
                                        case 4:    box.Text = pirate[2];  break;
                                        case 8:    box.Text = pirate[3];  break;
                                        case 16:   box.Text = pirate[4];  break;
                                        case 32:   box.Text = pirate[5];  break;
                                        case 64:   box.Text = pirate[6];  break;
                                        case 128:  box.Text = pirate[7];  break;
                                        case 256:  box.Text = pirate[8];  break;
                                        case 512:  box.Text = pirate[9];  break;
                                        case 1024: box.Text = pirate[10]; break;
                                        case 2048: box.Text = pirate[11]; break;
                                        default: 
                                            box.Text = map[i, j].ToString();
                                            warn.Text = "Win"; 
                                            break;
                                    }
                                    break;
                            }
                            box.BackColor = GetNumberColor(map[i, j]);
                        }
                    }
                }
            }
            Score += backScore;
            _score.Text = Score.ToString();
            if (Score > Best)
            {
                Best = Score;
                _best.Text = Best.ToString();
            }
        }
        private static Color GetNumberColor(int num)//获取对应的颜色
        {
            switch (num)
            {
                case 0: return Color.Linen;
                case 2: return Color.AliceBlue;
                case 4: return Color.LightCoral;
                case 8: return Color.OrangeRed;
                case 16: return Color.LightGreen;
                case 32: return Color.Gold;
                case 64: return Color.Orange;
                case 128: return Color.LightSkyBlue;
                case 256: return Color.DeepSkyBlue;
                case 512: return Color.MediumPurple;
                case 1024: return Color.Indigo;
                case 2048: return Color.Violet;
                default: return Color.Red;
            }
        }
        private void move()
        {
            int cs = 0;
            if (flag == false)
            {
                copy();
            }
            switch (move_key)//将map中的非0元素全部移向一边
            {
                case move_player.up:
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            while (map[x, y] == 0 && cs < 4)
                            {
                                for (int i = x; i < 4; i++)
                                {
                                    if (i == 3) map[i, y] = 0;
                                    else map[i, y] = map[i + 1, y];
                                }
                                cs++;
                            }
                            if (cs > 3) { cs = 0; break; }
                            else cs = 0;
                        }
                    }
                    break;
                case move_player.down:
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 3; x >= 0; x--)
                        {
                            while (map[x, y] == 0 && cs < 4)
                            {
                                for (int i = x; i >= 0; i--)
                                {
                                    if (i == 0) map[i, y] = 0;
                                    else map[i, y] = map[i - 1, y];
                                }
                                cs++;
                            }
                            if (cs > 4) { cs = 0; break; }
                            else cs = 0;
                        }
                    }
                    break;
                case move_player.left:
                    for (int x = 0; x < 4; x++)
                    {
                        for (int y = 0; y < 4; y++)
                        {
                            while (map[x, y] == 0 && cs < 4)
                            {
                                for (int i = y; i < 4; i++)
                                {
                                    if (i == 3) map[x, i] = 0;
                                    else map[x, i] = map[x, i + 1];
                                }
                                cs++;
                            }
                            if (cs > 3) { cs = 0; break; }
                            else cs = 0;
                        }
                    }
                    break;
                case move_player.right:
                    for (int x = 0; x < 4; x++)
                    {
                        for (int y = 3; y >= 0; y--)
                        {
                            while (map[x, y] == 0 && cs < 4)
                            {
                                for (int i = y; i >= 0; i--)
                                {
                                    if (i == 0) map[x, i] = 0;
                                    else map[x, i] = map[x, i - 1];
                                }
                                cs++;
                            }
                            if (cs > 3) { cs = 0; break; }
                            else cs = 0;
                        }
                    }
                    break;
            }
            if (flag == false)
            {
                move_add();
            }
            else
            {
                bool empty = false;
                flag = false;
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        if (map[x, y] == 0)
                        {
                            empty = true;
                            break;
                        }
                    }
                    if (empty)
                        break;
                }
                //如果不移动或者map无0，则不新增元素
                if (!Equel() && empty)
                {
                    PutNewValue();
                    if (play)
                        player.Play();
                }
            }
        }//移动地图；
        private void move_add()
        {
            backScore = 0;
            switch (move_key)
            {
                case move_player.up:
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 3; x++)
                        {

                            if (map[x, y] == map[x + 1, y])
                            {
                                map[x, y] += map[x + 1, y];
                                backScore += map[x, y];
                                map[x + 1, y] = 0;
                            }

                        }
                    }
                    break;
                case move_player.down:
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 3; x > 0; x--)
                        {
                            if (map[x, y] == map[x - 1, y])
                            {
                                map[x, y] += map[x - 1, y];
                                backScore += map[x, y];
                                map[x - 1, y] = 0;
                            }
                        }
                    }
                    break;
                case move_player.left:
                    for (int x = 0; x < 4; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {

                            if (map[x, y] == map[x, y + 1])
                            {
                                map[x, y] += map[x, y + 1];
                                backScore += map[x, y];
                                map[x, y + 1] = 0;
                            }

                        }
                    }
                    break;
                case move_player.right:
                    for (int x = 0; x < 4; x++)
                    {
                        for (int y = 3; y > 0; y--)
                        {
                            if (map[x, y] == map[x, y - 1])
                            {
                                map[x, y] += map[x, y - 1];
                                backScore += map[x, y];
                                map[x, y - 1] = 0;
                            }
                        }
                    }
                    break;
            }
            flag = true;
            move();
        }//合并相同项；
        private bool IsDead()//判断是否结束游戏
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (map[i, j] == 0)
                        return false;
                    if (i + 1 < 4)
                    {
                        if (map[i + 1, j] == 0 || map[i, j] == map[i + 1, j])
                            return false;
                    }
                    if (j + 1 < 4)
                    {
                        if (map[i, j + 1] == 0 || map[i, j] == map[i, j + 1])
                            return false;
                    }
                }
            }
            return true;
        }
        private void new_game_Click(object sender, EventArgs e)//开始新游戏
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    map[i, j] = 0;
                }
            }

            timer2.Enabled = true;
            title.Font = new Font(title.Font.FontFamily, 49, title.Font.Style);
            player = new SoundPlayer("E:\\school\\learning\\C#\\2048\\课设\\wav\\attack1.wav");

            _score.Text = "0";
            Score = 0;
            warn.Text = "新游戏";
            PutNewValue();
            PutNewValue();
            Display(Box, warn, type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                copy();
                timer1.Enabled = true;
                warn.Text = "闪烁中";
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        map[i, j] = cp[i, j];
                    }
                }
                Display(Box, warn, type);
                timer1.Enabled = false;
                warn.Text = "停止闪烁";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)//用于闪烁
        {
            backScore = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    map[i, j] = 0;
                }
            }

            PutNewValue();
            PutNewValue();
            Display(Box, warn, type);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)//检测键盘输入和是否输
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    warn.Text = "up";
                    move_key = move_player.up;
                    this.move();
                    Display(Box, warn, type);
                    break;
                case Keys.S:
                    warn.Text = "down";
                    move_key = move_player.down;
                    this.move();
                    Display(Box, warn, type);
                    break;
                case Keys.A:
                    warn.Text = "left";
                    move_key = move_player.left;
                    this.move();
                    Display(Box, warn, type);
                    break;
                case Keys.D:
                    warn.Text = "right";
                    move_key = move_player.right;
                    this.move();
                    Display(Box, warn, type);
                    break;
                case Keys.E:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            map[i, j] = cp[i, j];
                        }
                    }
                    warn.Text = "back";
                    backScore = 0 - backScore;
                    Display(Box, warn, type);
                    break;
                case Keys.Q:
                    Score = 0;
                    backScore = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            map[i, j] = 0;
                        }
                    }
                    player = new SoundPlayer("E:\\school\\learning\\C#\\2048\\课设\\wav\\failed.wav");
                    player.Play();
                    warn.Text = "over";
                    break;
            }
            if (IsDead())
            {
                player = new SoundPlayer("E:\\school\\learning\\C#\\2048\\课设\\wav\\failed.wav");
                player.Play();
                warn.Text = "Failed";
                return;
            }
        }
        private void Speaker_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                Speaker.Image = Image.FromFile("E:\\school\\learning\\C#\\2048\\课设\\image\\no.png");
                play = false;
            }
            else if (play == false)
            {
                Speaker.Image = Image.FromFile("E:\\school\\learning\\C#\\2048\\课设\\image\\yes.png");
                play = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            title.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}