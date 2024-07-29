#include <iostream>
#include <string>
using namespace std;

class calc {
	int tcase;
	string result;
public:
	void get();
};

void calc::get() {
	cin.tie(NULL);
	ios::sync_with_stdio(false);
	cin >> tcase;
	for (int i = 0; i < tcase; i++) {
		cin >> result;
		int count = 0;
		int point = 0;
		for (int j = 0; j < result.length(); j++) {
			if (result[j] == 'O') {
				count += 1;
				point = point + count;
			}
			else
				count = 0;
		}
		cout << point << '\n';
	}
}

int main() {
	calc c;
	c.get();
}