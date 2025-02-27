### while文
while(条件)
{
    処理;
}
### 例文
int i = 0;
// 絶対いつかtrueになるような条件にする
while(i < 10)
{
    i++;
    // 3をスキップして次のループに入る
    if(i == 3)
    {
        continue;
    }
    // 5の時点でループが終了される
    if(i == 5)
    {
        break;
    }

    MessageBox.Show(i.ToString());
}