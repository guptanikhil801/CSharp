echo "enter x1, x2"
read x1
read x2
echo "enter y1, y2"
read y1
read y2
dx=$(($x2-$x1))
dy=$(($y2-$y1))
px=$( awk -v a=$dx 'BEGIN { print (a^2) } ' )
py=$( awk -v a=$dy 'BEGIN { print (a^2) } ' )
sumxy=$(($px+$py))
echo $sumxy
distance=$( awk -v a=$sumxy 'BEGIN { print sqrt(a) } ' )
echo "distance is $distance"
