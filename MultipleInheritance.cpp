// Example program
#include <iostream>
#include <string>

class Printer {
public:void Print() {
	std::cout << "Printing Document";
}

};

class Scanner {
public:void Scan() {
	std::cout << "Scanning Document";
}

};

class PrintScanner :public Printer, public Scanner {

};

class PrintManager {

public: void PrintDocument(Printer* obj) {
	obj->Print();
}
};
class ScanManager {

public: void ScanDocument(Scanner* obj) {
	obj->Scan();
}
};

int main()
{

	PrintScanner* _printScanner = new PrintScanner();

	PrintManager* _print_mg_ref = new PrintManager();
	_print_mg_ref->PrintDocument(_printScanner);

	ScanManager* _scan_mg_ref = new ScanManager();
	_scan_mg_ref->ScanDocument(_printScanner);
}