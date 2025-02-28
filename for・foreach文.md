### for文
for(int i = 0;i < 5; i++)
{
    処理;
}

### 例文
for (int i = 0;i < 5;i++)
{
    MessageBox.Show(i.ToString());
}

for(int i = 5; i>=0; i--)
{
    if(i == 4)
    {
        continue;
    }
    if(i==2)
    {
        break;
    }
    MessageBox.Show(i.ToString());
}

### foreach
foreach(データ型 反復変数 in コレクション)
{
    処理;
}
forとの違いは最初から最後までループすること
インデックス指定しないためミスが減る
foreachは値を変えたり消したりする時には使わない

### 例文

List<int>items = new List<int>();
items.Add(10);
items.Add(20);
items.Add(30);
items.Add(40);

// itemsの中を取り出してitemに入れる
foreach(int item in items)
{
    if(item == 20)
    {
        continue;
    }
    if(item == 30)
    {
        break;
    }
    MessageBox.SHow(item.ToString());
}
⇩
10

List<int>items = new List<int>();
items.Add(10);
items.Add(20);
items.Add(30);
items.Add(40);

// itemsの中を取り出してitemに入れる
foreach(int item in items)
{
    items[1] = 22; //中身を変えられずエラーとなる
    items.Remove(item); // 中身を消すこともできずエラーとなる
    MessageBox.SHow(item.ToString());
}

### 中身を消したい場合のfor文
List<int>items = new List<int>();
items.Add(10);
items.Add(20);
items.Add(30);
items.Add(40);

// 逆回しで進めないとインデックスの中身がズレる
for(i = items.Count -1; i >= 0; i --;)
{
    if(items[i] == 10)
    {
        items.RemoveAt(i);
    }
    MessageBox.SHow(item.ToString());
}