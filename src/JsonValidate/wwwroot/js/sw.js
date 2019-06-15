self.addEventListener('install', e => {
    e.waitUntil(
      caches.open('jsonvalidate').then(cache => {
        return cache.addAll([
       // Blazor files
       '/',
       '/_framework/_bin/JsonValidate.dll',
       '/_framework/_bin/Microsoft.AspNetCore.Blazor.dll',
       '/_framework/_bin/Microsoft.AspNetCore.Components.Browser.dll',
       '/_framework/_bin/Microsoft.AspNetCore.Components.dll',
       '/_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll',
       '/_framework/_bin/Microsoft.Extensions.DependencyInjection.dll',
       '/_framework/_bin/Microsoft.JSInterop.dll',
       '/_framework/_bin/Mono.Security.dll',
       '/_framework/_bin/Mono.WebAssembly.Interop.dll',
       '/_framework/_bin/mscorlib.dll',
       '/_framework/_bin/System.Buffers.dll',
       '/_framework/_bin/System.ComponentModel.Annotations.dll',
       '/_framework/_bin/System.Core.dll',
       '/_framework/_bin/System.dll',
       '/_framework/_bin/System.Memory.dll',
       '/_framework/_bin/System.Net.Http.dll',
       '/_framework/_bin/System.Numerics.Vectors.dll',
       '/_framework/_bin/System.Runtime.CompilerServices.Unsafe.dll',
       '/_framework/_bin/System.Text.Json.dll',
       '/_framework/_bin/System.Threading.Tasks.Extensions.dll',
       '/_framework/wasm/mono.js',
       '/_framework/wasm/mono.wasm',
       '/_framework/blazor.boot.json',
       '/_framework/blazor.server.js',
       '/_framework/blazor.webassembly.js',

       // Static files
       '/css/site.css',
       '/images/logo.png',
       '/js/sw.js',
       '/favicon.ico',
       '/index.html',

       // CDN files
       'https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css',
       'https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.8.2/css/all.min.css',
       'https://cdn.jsdelivr.net/npm/cookieconsent@3/build/cookieconsent.min.css',
       'https://cdn.jsdelivr.net/npm/cookieconsent@3/build/cookieconsent.min.js'
        ])
            .then(() => self.skipWaiting());
      })
    );
  });
  
  self.addEventListener('activate', event => {
    event.waitUntil(self.clients.claim());
  });
  
  self.addEventListener('fetch', event => {
    event.respondWith(
      caches.open(cacheName)
        .then(cache => cache.match(event.request, {ignoreSearch: true}))
        .then(response => {
        return response || fetch(event.request);
      })
    );
  });