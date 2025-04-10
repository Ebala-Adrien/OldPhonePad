# Old Phone Pad Decoder

This project implements the requirements specified in `C# Coding Challenge.pdf` file.

## 🚀 Installation and Usage

### 1. Install .NET SDK

Download and install the .NET SDK from the official website:
https://dotnet.microsoft.com/download

### 2. Clone and Setup

```bash
git clone this repository
cd OldPhonePad
```

### 3. Run Tests

To verify everything works correctly:

```bash
dotnet run -- --test
```

### 4. Run Program

To use the program:

```bash
dotnet run
```

Enter your sequence when prompted and press Enter.

## 📝 Notes

### Test Cases

The following test cases are included:

- `33#` → `E`
- `227*#` → `B`
- `4433555 555666#` → `HELLO`
- `8 88777444666*664#` → `TURING`

### Additional Feature

While not required by the assignment, I implemented a cycling mechanism for letter selection. This means that if you press a key more times than it has letters (e.g., pressing 2 four times), it will cycle back to the beginning of the letter sequence.

## 📝 Input Format

- Use numbers 2-9 to represent letters
- Use `*` for backspace
- Use 0 for word separation
- End your sequence with `#`

## 📚 Number to Letter Mapping

- 0: Space
- 1: &'(
- 2: abc
- 3: def
- 4: ghi
- 5: jkl
- 6: mno
- 7: pqrs
- 8: tuv
- 9: wxyz
