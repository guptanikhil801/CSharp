echo "enter any key to start watch "
read n
start=$( date +%s)
echo "start time is $start"
echo "enter any key to stop watch "
read e
stop=$( date +"%s")
elapsed=$(($stop - $start))
echo "elapsed time is $elapsed"
