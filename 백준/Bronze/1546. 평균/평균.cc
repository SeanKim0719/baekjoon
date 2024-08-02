#include <iostream>
using namespace std;

class change {
	int tcase;
	float point[1000] = {};
	float max = 0;
	float sum = 0;
public:
	void maxpoint();
};

void change::maxpoint() {
	cin >> tcase;
	for (int i = 0; i < tcase; i++) {
		cin >> point[i];
		sum += point[i];
		if (point[i] > max)
			max = point[i];
	}
	sum = (sum / max * 100) / tcase;
	cout << sum;
}

int main() {
	change c;
	c.maxpoint();
}