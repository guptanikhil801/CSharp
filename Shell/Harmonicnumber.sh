echo "enter nth term "
read n
har=0
for (( i=1; i<=n; i++ ))
do
har=$( awk -v a=$har -v b=$i 'BEGIN { print ( a + 1/b ) } ' )
done
echo $har
