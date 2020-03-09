echo "enter number"
read n
for (( i=2; i*i<=n; i++ ))
do
while (( $n % $i == 0 ))
do
echo $i
let 'n = n/i'
done
done
if [ $n > 2 ]
then
echo $n
fi
