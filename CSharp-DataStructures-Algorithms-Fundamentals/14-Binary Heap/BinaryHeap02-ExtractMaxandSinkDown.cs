using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
	public partial class MaxBinaryHeap
	{
		public int ExtractMax()
		{
			if (values.Count == 0) throw new InvalidOperationException("Heap is empty.");

			int max = values[0];
			int end = values[values.Count - 1];
			values.RemoveAt(values.Count - 1);

			if (values.Count > 0)
			{
				values[0] = end;
				SinkDown();
			}

			return max;
		}

		private void SinkDown()
		{
			int idx = 0; // Start at the root of the heap (index 0)
			int length = values.Count; // The total number of elements in the heap
			int element = values[0]; // The element at the root (the one that needs to be "sunk")

			while (true) // Keep looping until the element sinks to its correct position
			{
				int leftChildIdx = 2 * idx + 1;  // Obtain left child index (2 * idx + 1)
				int rightChildIdx = 2 * idx + 2; // Obtain right child index (2 * idx + 2)
				int leftChild, rightChild;
				int swap = -1; // -1 indicates that no child has been selected for swapping yet

				if (leftChildIdx < length) // Check if the left child exists (left child index within bounds)
				{
					leftChild = values[leftChildIdx]; // Get the left child's value
					if (leftChild > element) // If the left child is greater than the element at the current index
					{
						swap = leftChildIdx; // Mark the left child for swapping
					}
				}

				if (rightChildIdx < length) // Check if the right child exists (right child index within bounds)
				{
					rightChild = values[rightChildIdx]; // Get the right child's value
					if (
						(swap == -1 && rightChild > element) || // If no swap was selected yet, compare right child with current element
						(swap != -1 && rightChild > values[swap]) // If a swap was selected, compare the right child to the left child (the largest child)
					)
					{
						swap = rightChildIdx; // Mark the right child for swapping (if it's larger than the left child)
					}
				}

				if (swap == -1) break; // If no swap is necessary (both children are smaller or equal to the current element), exit the loop

				// Swap the element at the current index with the larger child (either left or right)
				values[idx] = values[swap];
				values[swap] = element;

				idx = swap; // Move down to the new position where the element was swapped
			}
		}
	}
}

/*
	class Program
	{
		static void Main()
		{
			MaxBinaryHeap heap = new MaxBinaryHeap();

			heap.Insert(41);
			heap.Insert(39);
			heap.Insert(33);
			heap.Insert(18);
			heap.Insert(27);
			heap.Insert(12);
			heap.Insert(55); // 55 was inserted last, but it "bubbled up" because it was the highest priority value
			heap.ExtractMax(); // returns the topmost element (55)

			// Order before extract max and sink down:
			/*
						   55
					  39        41
					18  27    12   33
			*/

			// Extract max: return 55
			// Sink down:
			// Take the last element (33) and compare it to 55's left and right children
/*
After extracting the root element(55) from the heap:

                       55
                  39        41
                18  27    12   33

Step 1: Move the last element(33) to the root:
The last element(33) will replace the root(55).

                       33
                  39        41
                18  27    12   

Step 2: Sink down the root(33) to restore the heap property:
Compare 33 with its children(39 and 41).
The largest child is 41, so swap 33 with 41.
markdown
Copy
Edit
                       41
                  39        33
                18  27    12   


/*
 * 
In a max binary heap, the **SinkDown** method is responsible for restoring the heap property after the maximum element 
(which is always at the root) has been extracted. This is necessary because when the root element is removed, 
the last element of the heap (the element at the end of the list) is moved to the root position, which may violate the heap 
property (the parent should be greater than or equal to its children).

Here's a detailed step-by-step breakdown of how **SinkDown** works:

1. **Initialize Values**:
   - `idx = 0`: Start from the root of the heap (index 0).
   - `element = values[0]`: The element at the root (the one that was moved from the bottom).
   - `length = values.Count`: The total number of elements in the heap.

2. **Loop to Maintain the Heap Property**:
   - The method runs in a `while (true)` loop, which continues until no more swaps are necessary.

3. **Calculate Left and Right Children**:
   - The left child of an element at index `idx` is at `2 * idx + 1`.
   - The right child of an element at index `idx` is at `2 * idx + 2`.

4. **Check for Left Child**:
   - If the left child index is within bounds (`leftChildIdx < length`), compare the left child to the current element.
   - If the left child is greater than the current element, set the `swap` variable to the left child's index. 
This indicates that the left child is a candidate for swapping.

5. **Check for Right Child**:
   - Similarly, check the right child.
   - If the right child exists (`rightChildIdx < length`), compare it to both the current element and the left child 
(if already marked for a swap).
   - If the right child is larger than either the current element or the left child (depending on whether the left child was swapped), 
set the `swap` variable to the index of the right child.

6. **Decide if a Swap Is Necessary**:
   - If `swap == -1`, it means neither child is larger than the current element, and the loop breaks because no further swaps are needed.
   - If `swap` is not `-1`, a swap will occur: the current element is swapped with the larger of the two children 
(either the left or right child), and the `idx` is updated to the new position (`swap`).

7. **Repeat Until Heap Property Is Restored**:
   - The method continues to "sink down" the element by swapping it with its larger child and then checking its new children, 
repeating until the heap property is satisfied.

### Example:
Let's say the heap looks like this:

        41
      /    \
    39      33
   /  \    /  \
 18   27 12   55

After extracting the maximum (41), the last element (55) is moved to the root, and the heap looks like this:

        55
      /    \
    39      33
   /  \    /  \
 18   27 12

Now, `SinkDown` will start from the root:

- First, the left child (39) and right child (33) are compared to 55. Since 39 is the largest, we swap 55 with 39:
  
        39
      /    \
    55      33
   /  \    /  \
 18   27 12

- Now, `SinkDown` continues from index 1, where 55 is. The children of 55 are 18 and 27. Since 27 is larger than 18, we swap 55 with 27:
  
        39
      /    \
    27      33
   /  \    /  \
 18   55 12

- Finally, 55 is checked at index 3, but it has no children (it's a leaf node), so the loop stops.

The heap now looks like this, with the heap property restored:

        39
      /    \
    27      33
   /  \    /  \
 18   55 12

In summary, **SinkDown** ensures that after removing the root of the heap and replacing it with the last element, 
the heap property is restored by swapping the new root element down to its correct position.

*/