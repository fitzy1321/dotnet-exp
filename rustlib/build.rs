use std::env;

fn main() {
    // what's the current dir?
    let cwd = env::current_dir().unwrap();

    println!("Current working dir: {:?}", &cwd);

    csbindgen::Builder::default()
        .input_extern_file("src/lib.rs")
        .csharp_dll_name("example")
        .generate_csharp_file("target/dotnet/NativeMethods.g.cs")
        .unwrap();
}
