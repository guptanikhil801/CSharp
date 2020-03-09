echo "enter temperature"
read t
echo "enter wind speed "
read v
ws=$( awk -v a=$t -v b=$v 'BEGIN { print ( 35.74 +0.6215*a + (0.4275*a-35.75) * (b^0.16) ) } ' )
echo $ws
