echo "enter number "
read num
prod=2
if [ $num -lt 31 ]
then
for (( i=1; i<=$num; i++ ))
do
echo $prod
let "prod*=2"
done
fi

