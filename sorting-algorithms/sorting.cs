public static class Sorting{

    public static int[] BubbleSort(int[] unsorted){

        int count = 0;
        bool inOrder;

        do{

            inOrder = true;

            int lastItem = unsorted[0];
            for(int i = 1; i < unsorted.Length - count; i++){
        
                int currentItem = unsorted[i];

                if(lastItem > currentItem){

                    unsorted[i] = lastItem;
                    unsorted[i-1] = currentItem;
                    inOrder = false;

                }
                lastItem = unsorted[i];

            }

            count++;

        }while(!inOrder);

        return unsorted;

    }

}