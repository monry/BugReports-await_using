# Overview

Unity project to reproduce a bug occurs compile error when using "await using" in C# 8.0

# Details

## Steps to reproduce

1. Open project.
1. Compile error occurs in using `await using`
    ```
    Assets/Scripts/EntryPoint.cs(12,17): error CS0518: Predefined type 'System.IAsyncDisposable' is not defined or imported
    ```

## Expected behaviour

No compile error occurs.

## Environment

- Unity 2021.1.19f1
- C# 8.0

## Notes

If uncomment [`Workaround.cs`](Assets/Scripts/Workaround.cs), no compile error reported and project works correctly.

![image](https://user-images.githubusercontent.com/838945/131770992-40aae27d-7ecc-4540-bb2e-5b0239a23a50.png)
Screenshot the result of running `Assets/Scenes/SampleScene.unity`
