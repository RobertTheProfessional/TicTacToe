#include "stdio.h"
#include "stdlib.h"
#include "math.h"

#define O 0
#define X 1

/******************************************************************************
Board is represented by the first 9 bits of two shorts (grid and occupied).
If a space is occupied, its occupied bit is set to 1.
In the grid a 1 bit represents x, a 0 bit represents o.
*****************************************************************************/
unsigned short grid;
unsigned short occupied;

void init() {
	occupied = 0;
}

void printGrid() {
	unsigned short i = 1;
	do {
		if (occupied & i) {
			if (grid & i) {
				printf("x");
			}
			else {
				printf("o");
			}
		}
		else {
			printf("-");
		}
		if (i & 292) {
			printf("\n");
		}
		i <<= 1;
	} while (i != 512);
}

char isOccupied(unsigned char x, unsigned char y) {
	// assumes x and y are < 3
	return (occupied & 1 << (3 * y + x));
}

char drawCheck() {
	return (occupied == 511);
}

void set(unsigned char x, unsigned char y, unsigned char player) {
	// assumes x and y are < 3
	unsigned short pos = 1 << (3 * y + x);
	occupied |= pos;
	if (player == X) grid |= pos;
	else grid &= ~pos;
}

char winCheck(char player) {
	unsigned short tmpgrid;
	if (player == X) tmpgrid = grid & occupied;
	if (player == O) tmpgrid = (~grid) & occupied;
	return (((grid | 7) == grid) ||
		((grid | 56) == grid) ||
		((grid | 73) == grid) ||
		((grid | 84) == grid) ||
		((grid | 146) == grid) ||
		((grid | 273) == grid) ||
		((grid | 292) == grid) ||
		((grid | 448) == grid));
}

int main() {
	unsigned char x, y, player;

	player = X;
	init();
	printf("Enter an xy coordinate between 0 and 2 (Ex: 21)\n");
	while (1) {
		x = getchar();
		y = getchar();
		getchar();
		if (isOccupied(x, y)) {
			printf("Space occupied. Try again.\n");
			continue;
		}
		set(x, y, player);
		printGrid();

		if (winCheck(player)) {
			printf("Winner!\n");
			break;
		}
		if (drawCheck()) {
			printf("Draw.\n");
			break;
		}
		player ^= 1;
		printf("\n");
	}
}