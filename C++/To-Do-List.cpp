#include <iostream>
#include <vector>
#include <string>

using namespace std;

// Task structure to hold task details
struct Task {
    string description;
    bool completed;

    Task(string desc) : description(desc), completed(false) {}
};

// Function prototypes
void displayMenu();
void addTask(vector<Task>& tasks);
void removeTask(vector<Task>& tasks);
void viewTasks(const vector<Task>& tasks);

int main() {
    vector<Task> tasks;
    char choice;

    do {
        displayMenu();
        cin >> choice;
        cin.ignore(); // Clear buffer

        switch (choice) {
            case '1':
                addTask(tasks);
                break;
            case '2':
                removeTask(tasks);
                break;
            case '3':
                viewTasks(tasks);
                break;
            case '4':
                cout << "Exiting program.\n";
                break;
            default:
                cout << "Invalid choice. Please try again.\n";
        }
    } while (choice != '4');

    return 0;
}

// Function to display menu options
void displayMenu() {
    cout << "\nTo-Do List Manager\n";
    cout << "1. Add Task\n";
    cout << "2. Remove Task\n";
    cout << "3. View Tasks\n";
    cout << "4. Exit\n";
    cout << "Enter your choice: ";
}

// Function to add a new task
void addTask(vector<Task>& tasks) {
    cout << "Enter task description: ";
    string desc;
    getline(cin, desc);
    tasks.push_back(Task(desc));
    cout << "Task added successfully.\n";
}

// Function to remove a task
void removeTask(vector<Task>& tasks) {
    if (tasks.empty()) {
        cout << "No tasks to remove.\n";
        return;
    }

    cout << "Enter index of task to remove (1-" << tasks.size() << "): ";
    int index;
    cin >> index;

    if (index < 1 || index > tasks.size()) {
        cout << "Invalid index.\n";
        return;
    }

    tasks.erase(tasks.begin() + index - 1);
    cout << "Task removed successfully.\n";
}

// Function to view all tasks
void viewTasks(const vector<Task>& tasks) {
    if (tasks.empty()) {
        cout << "No tasks to display.\n";
        return;
    }

    cout << "\nTasks:\n";
    for (size_t i = 0; i < tasks.size(); ++i) {
        cout << i + 1 << ". " << (tasks[i].completed ? "[X] " : "[ ] ") << tasks[i].description << endl;
    }
}