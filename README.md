# The Millionaire Mind
Windows Form Project by: Kristina Srbinoska
# ОПИС НА ИГРАТА
The Milionare Mind е варијанта на  Who Wants to Be a Millionaire? и целта на играта е играчот преку погодување на точните одговори да стигне до целта,односно милионот.
Во оваа игра освен основните функционалности играчот ќе има можност при влез во играта да направи свој профил и за подоцна да се прикаже неговиот резултат во ранг листа.
Додаден е и тајмер кој ќе одбројува време за секое прашање, како и копче кое води до моменталната ранг листа.
# Упатсво за користење
1. Стартување на игра
- Во даден момент може да игра само еден играч(single player mode)
- При стартување на играта играчот креира свој профил со клик на копчето ,,Нов Играч"
    ![image](https://github.com/user-attachments/assets/25201f54-fc0e-477f-91ec-8097f5c232e8)
2. Креирање на профил    
- По кликање на кошето ,,Нов играч",се отвора прозорец каде што играчот внесува име и поставува слика.
  ![image](https://github.com/user-attachments/assets/d227a15d-a6e1-4f61-86ef-9c96ee831ba7)
3. Почеток на квизот  
- Откако ќе се креира профил, копчето каде што е напишано името на ирачот ќе овозможува да се прикажуваат прашањата,после секое точно одговорено прашање кликаме на него
  
  ![image](https://github.com/user-attachments/assets/0cf8dd22-1241-4b84-a571-5bebff6696a7)
  ![image](https://github.com/user-attachments/assets/1522a2ef-8606-4247-b263-a40ba7b9f2fe)
4. Команди
- При клик на иконата која претставува телефонска слушалка се отвора панел кој му овозможува на играчот да побара помош од пријател( можноста за помош е лимитирана на 3 јавувања)
  ![image](https://github.com/user-attachments/assets/a809bd2d-0f98-4d9b-a3de-3ca3063b5116)
- При клик на  втората икона играчот ќе има можност да побара помош од публика каде што ќе се отвори при клик втор панел,каде при клик на копчето ,,Прашај", процентуално ќе биде генерирано кој одговор би бил точен( ова е имплементирано со помош на Random метода).
 ![image](https://github.com/user-attachments/assets/95834082-f889-48b2-b1a7-123021e18977)
- При клик на иконата 50/50 ќе бидат елеминирани две опции и ќе биде присутна само точната опција и една погрешна и играчот ќе има избор од само две опции.
   ![image](https://github.com/user-attachments/assets/2f85d8a1-fbe7-41d5-bdb6-8f852130f133)
- При клик на копчето LeaderBoard, играчот ќе може да ја види моменталната ранг листа на играчите до тој момент.
  ![image](https://github.com/user-attachments/assets/83d4f664-9cc7-44e1-8352-bd5b3c240eb4)
- При секое точно одгворено прашање се прикажува анимација при која дадениот одговор пулсира и менува боја,тоа е пропратено со звук(,,Correct").
 ![image](https://github.com/user-attachments/assets/f4760743-e3ab-4e4e-a54d-fc3f567ec67d)
- При секое неточно одговорено прашање одговорот се маркира со црвена боја(пропратено со звук за неточно прашање) и се прикажува порака дека не сме го освоиле милионот и играта завршува.
  ![image](https://github.com/user-attachments/assets/7e928c77-429d-4867-b411-5d4d04518543)
- Доколку сите прашања се точно одговорени ирачот победува и се прикажува прозорец во кој пишува ,,Ти си милионер",клика играчот Океј и се прикажува рејтинг листата и во позадина има музика согласно со тематиката на играта(играј до крај и дознај со која музика слави победникот).
  # ОПИС НА РЕШЕНИЕТО
  Играта е поделена во две форми,првата е основна форма Form1.cs каде што е имплементирана логиката на поголем дел од функционалностите,односно анимациите при кликање на одговор на прашање,имплементиран е тајмерот кој се вклучува при секое прашање,копчето на кое е прикажано името и кое служи за преминување од едно на друго прашање,функција која ќе овозможи при исполнување на услов да заврши играта,функционалностите на иконите за повикај пријател,помош од публика и 50/50, како и копче ,,Leaderboard",кое води до формата LeaderboardForm.cs каде што е прикажана рејтинг листата, за оваа цел ја креираме и Player.cs класата која чува име и поени на секој играч. Копчето на кое е прикажано името не води до формата PlayerSetupForm, каде се поставува слика на играчот и неговото име.
  # ОПИС НА ФУНКЦИИ
  ```csharp
  private void q1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "2" || label1.Text == "4" || label1.Text == "7" || label1.Text == "9" || label1.Text == "12")
            {
                q1.FillColor = Color.DarkGreen;
                PlaySound("correct.wav");
                AnimateControl(q1, Color.DarkGreen);
            }
            else
            {
                q1.FillColor = Color.DarkRed;
                PlaySound("incorrect.wav");
                MessageBox.Show("Не го освои милионот...");
                AnimateControl(q1, Color.DarkRed);
                EndGame();
            }
            if (q1.FillColor == Color.DarkGreen && label1.Text == "12")
            {
                MessageBox.Show("ТИ СИ МИЛИОНЕР!!!");
                PlaySound("milionerce.mp3");
                EndGame();
            }
        }
  ```
  Оваа функција овозможува при клик на одговор на прашање да се одреди дали одговорот е точен. Ова е имплементирано така што се земаат редните броеви на одговорите label1.Text и доколку го исполнуваат условот полето се обојува зелено, со помош на  WindowsMediaPlayer(кој е овозможен во функцијата PlaySound()) овозможуваме да се прикаже звукот и со фукцијата AnimateControl() која е претходно имплеменирана се прикажува анимацијата, во оваа фукција исто така е искористена и функцијата EndGame(),која ќе ја прикажам во продолжение.
```csharp
private void EndGame()
{
    string playerName = guna2Button1.Text;
    int score = totalPoints;
    UpdateLeaderboard(playerName, score);
    ShowLeaderboard();
    ResetGameState();
    this.Close();
}
```
Во оваа функција е предадено името на моменталниот играч како и неговите поени кои се потребни во UpdateLeaderboard() функцијата како при завршување на ирата играчот би се прикажал во табелата со рејтинзи(ShowLeaderboard()).
ResetGameState() ни е помошна функција која ни овозможува по завршување на играта прашањата и табелата со поени да се ресетира за новиот играч.
```csharp
private void guna2Button5_Click(object sender, EventArgs e)
{
    Random random = new Random();


    int percentage1 = random.Next(0, 101);
    int percentage2 = random.Next(0, 101 - percentage1);
    int percentage3 = random.Next(0, 101 - percentage1 - percentage2);
    int percentage4 = 100 - percentage1 - percentage2 - percentage3;


    if (percentage4 < 0)
    {

        percentage3 += percentage4;
        percentage4 = 0;
    }


    progressBar1.Value = percentage1;
    progressBar2.Value = percentage2;
    progressBar3.Value = percentage3;
    progressBar4.Value = percentage4;

    label37.Text = $"{percentage1}%";
    label38.Text = $"{percentage2}%";
    label39.Text = $"{percentage3}%";
    label40.Text = $"{percentage4}%";
}
```
Оваа  функција служи за да се ажурира панелот што се користи при прашување на публика, искроистена е рандом функцијата при што се пресметува секој пат некој рандом процент и се распределува рамномерно.
```csharp
 private void UpdateLeaderboard(string playerName, int score)
 {
     leaderboard.Add(new Player(playerName, score));
     leaderboard = leaderboard.OrderByDescending(p => p.Score).ToList();
     SaveLeaderboard();
 }
```
Оваа функција  во рејтинг листата го доадава играчот со неговиот score и листата на сите дотогашни играчи ја сортира по опаѓачки редослед. SaveLeaderboard() овозможува  резултатот од играта да се зачува во фајл кој е во json формат за да ни биде цело време достапна табелата со целата историја на дотогашните играчи.





