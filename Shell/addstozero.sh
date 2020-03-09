declare -a a
read -p 'enter size ' m
echo "enter elements "

   for (( i=0; i<m; i++ ))
    do
       read a[$i]
    done

           for (( i=0; i<m-2; i++ ))
            do
                for (( j=i+1; j<m-1; j++ ))
                 do
                     for (( k=j+1; k<m; k++ ))
                      do
                           sum=$(( a[$i]+a[$j]+a[$k] ))
                           if (( sum == 0 ))
                             then
                            echo "${a[$i]} ${a[$j]} ${a[$k]} "
                            fi
                      done
                 done
            done
