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

### do while文
do
{
    処理;
}while(条件)
処理を行ってから条件を見るため、必ず一回は処理が行われる。
### 例文
int i = 100;

do{
    i++;
}while(i < 10);

MessageBox.Show(i.ToString());

101

## 備考
while(true)は常にtrueなので無限ループとなる