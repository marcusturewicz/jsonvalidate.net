var cacheName = 'jsonvalidate';
self.addEventListener('install', e => {
    e.waitUntil(
      caches.open(cacheName).then(cache => {
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
       '/_content/JsonValidate.Clipboard/clipboard.js',

       // Static files
       '/css/site.css',
       '/images/logo.png',
       '/sw.js',
       '/favicon.ico',
       '/index.html',
       '/images/icons/icon-72x72.png',
       '/images/icons/icon-96x96.png',
       '/images/icons/icon-128x128.png',
       '/images/icons/icon-144x144.png',
       '/images/icons/icon-152x152.png',
       '/images/icons/icon-192x192.png',
       '/images/icons/icon-384x384.png',
       '/images/icons/icon-512x512.png',

       // CDN files
       'https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css',
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