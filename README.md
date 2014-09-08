C[CS]?ycles : CCycles and CSycles for Cycles
============================================

C[CS]?ycles aims to provide a C API around Cycles. Building on CCycles also a
C# wrapper is available.

*Note 1* current work relies on Boost 1.55.1 being in a specific location, and the
stage/ folder with libraries. A prebuilt version with properly named libs and
paths can be downloaded at: https://dl.dropboxusercontent.com/u/1769373/boost_1_55_0.7z

*Note 2* This is currently targeted at Windows platform only, but patches to
improve cross-platform compiling and executing are likely candidates for
acceptance

*Note 3* The grand plan is to improve CCycles and CSycles and prepare for
submission to Blender upstream repository. There are still many hurdles to jump
over before this project is ready for that. Until that moment main development
of both parts is conducted in this repository.

Cycles and dependencies
=======================

This folder contains the Cycles source code, C-API source code, C# wrapper
source code and source code for the necessary dependencies pthreads, glew,
clew, cuew and a modified OpenImageIO.

The Cycles source
=================

Current Cycles revision: 220fcd43a9e48c3ca7be766433495a54d5471d71 (previous: 9fcaac5009b567edc59c4831b6a0580211d1d290)

The Cycles source code is in the following folders:
  bvh (bounding volume hierarchy, https://en.wikipedia.org/wiki/Bounding_volume_hierarchy)
  device
  kernel
  render
  subd
  util

The 'doc' folder holds all license texts of Cycles and for the parts that are
directly used in Cycles.

OpenImageIO tools
=================

Only a small part of the OpenImageIO library is used on the Rhino version
of Cycles. Image loading is handled by Rhino existing image code.

pthreads
========

pthreads contains the threading library used by Cycles. The library is
compiled as a DLL.

clew
====

clew is the OpenCL execution wrangler library

cuew
====

cuew is the CUDA execution wrangler library

C-API and C# wrapper code
=========================

ccycles (C API)
csycles (C# wrapper around CCycles)

License for CCycles and CSycles
===============================

Copyright 2014 Robert McNeel and Associates

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.