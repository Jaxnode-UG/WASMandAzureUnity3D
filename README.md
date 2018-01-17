# Leveraging the Azure Cloud Services in Unity3D and WebAssembly

This repo has code examples from the January 2018 presentation at the Jaxnode user group. The webassembly examples are under the wasm directory. The following web urls can be used to reference the different resources used in the demo.

[http://webassembly.org/demo/](http://webassembly.org/demo/)

[https://mbebenita.github.io/WasmExplorer/](https://mbebenita.github.io/WasmExplorer/)

You can load the wasm file using the following JavaScript code;

```javascript
fetch('http://localhost:5000/wasm/test.wasm').then(res => res.arrayBuffer()).then(buf => WebAssembly.instantiate(buf));
```