using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        private Player player; // 플레이어 인스턴스
        private Queue<Monster> monsters; // 몬스터 대기열
        private Monster currentMonster; // 현재 전투 중인 몬스터
        private bool isPlayerTurn; // 현재 턴 상태

        public Form1()
        {
            InitializeComponent();

            // 플레이어 생성
            player = new Player("Hero", 100, 20);

            // 몬스터 리스트 생성
            monsters = new Queue<Monster>();
            monsters.Enqueue(new Orc("Orc", 80, 15));
            monsters.Enqueue(new Slime("Slime", 50, 10));

            // 첫 번째 몬스터 가져오기
            currentMonster = monsters.Dequeue();
            isPlayerTurn = true;

            // 초기 상태 출력
            Console.WriteLine("Battle Initialized!");
            Console.WriteLine($"{player.Name} vs {currentMonster.Name}");
            Console.WriteLine($"{player.Name} HP: {player.HP}, {currentMonster.Name} HP: {currentMonster.HP}");

            // KeyDown 이벤트 활성화
            this.KeyPreview = true; // 폼 전체에서 키 입력 감지
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 키 입력 시 턴 진행
            if (player.HP > 0 && currentMonster.HP > 0)
            {
                if (isPlayerTurn)
                {
                    // 플레이어 턴
                    player.Attack(currentMonster);
                    Console.WriteLine($"{player.Name} attacks {currentMonster.Name}!");
                    Console.WriteLine($"{currentMonster.Name}'s HP: {currentMonster.HP}");

                    if (currentMonster.HP <= 0)
                    {
                        Console.WriteLine($"{currentMonster.Name} is defeated!");

                        // 다음 몬스터 가져오기
                        if (monsters.Count > 0)
                        {
                            currentMonster = monsters.Dequeue();
                            Console.WriteLine($"Next battle: {player.Name} vs {currentMonster.Name}");
                        }
                        else
                        {
                            Console.WriteLine("All monsters are defeated!");
                            return;
                        }
                    }
                }
                else
                {
                    // 몬스터 턴
                    currentMonster.Attack(player);
                    Console.WriteLine($"{currentMonster.Name} attacks {player.Name}!");
                    Console.WriteLine($"{player.Name}'s HP: {player.HP}");

                    if (player.HP <= 0)
                    {
                        Console.WriteLine($"{player.Name} is defeated!");
                        return;
                    }
                }

                // 턴 전환
                isPlayerTurn = !isPlayerTurn;
            }
            else
            {
                Console.WriteLine("Battle already finished!");
            }
        }
    }
}
