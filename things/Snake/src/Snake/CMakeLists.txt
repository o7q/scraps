cmake_minimum_required(VERSION 3.10)

set(PROJECT_NAME "Snake")
project(${PROJECT_NAME})

set(SFML_DIR "C:/Program Files (x86)/SFML")

set(SFML_LIB ${SFML_DIR}/lib)
set(SFML_INCLUDE ${SFML_DIR}/include)

file(GLOB_RECURSE SOURCES "src/*.cpp")
add_executable(${PROJECT_NAME} ${SOURCES})

set_property(TARGET ${PROJECT_NAME} PROPERTY CXX_STANDARD 17)
set_property(TARGET ${PROJECT_NAME} PROPERTY CXX_STANDARD_REQUIRED ON)
target_compile_options(${PROJECT_NAME} PRIVATE -O2)

include_directories(${SFML_INCLUDE})

target_link_libraries(${PROJECT_NAME}
	-static-libgcc
	-static-libstdc++
    ${SFML_LIB}/libsfml-window-s.a
    ${SFML_LIB}/libsfml-graphics-s.a
    ${SFML_LIB}/libsfml-system-s.a
    opengl32
    winmm
    gdi32
    ${SFML_LIB}/libfreetype.a
)

target_compile_definitions(${PROJECT_NAME} PRIVATE SFML_STATIC)