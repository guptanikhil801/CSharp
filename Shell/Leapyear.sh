echo "enter year to check Leap Year"
read year
if [ $(( year % 4 )) -eq 0 ] && [ $(( year %100 )) -ne 0 ]
then
echo "Leap Year"
elif [ $(( year % 400 )) -eq 0 ]
then
echo "Leap year"
else
echo "Not a Leap year"
fi
