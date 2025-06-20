# FreeFileSync

![file-syncing-app](https://github.com/user-attachments/assets/83c005d8-dab3-4d2d-a624-59575b78eaaa)

## Inspiration

I created this project as a way to dive into C# .NET development by solving a real-world problem: keeping folders in sync without relying on third-party software.

## Challenges

- Designing a reliable file comparison and syncing algorithm
- Implementing multithreading to maintain UI responsiveness during sync operations
- Ensuring file integrity and avoiding unnecessary overwrites

## Lessons Learned

- Core concepts of C# and .NET application development
- How to implement multithreading and async operations in Windows Forms
- File system operations and safeguards to avoid data loss

## The Program

FreeFileSync is a desktop application that allows users to synchronize files between two directories with ease. Whether you're backing up data, mirroring a folder, or keeping two directories consistent, FreeFileSync provides three modes of synchronization:

- Left to Right – Copies files from the left directory to the right.
- Right to Left – Copies files from the right directory to the left.
- Two-Way Sync – Ensures both directories contain the same files.
