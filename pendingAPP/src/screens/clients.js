import { auto } from 'async';
import { StatusBar } from 'expo-status-bar';
import { hidden } from 'jest-haste-map/node_modules/chalk';
import { upperCase } from 'lodash';
import { StyleSheet, Text, View, Pressable, Image, TouchableOpacity } from 'react-native';
import { Searchbar } from 'react-native-paper';
import React, { Component } from 'react';
import 'react-native-gesture-handler';
import { ScrollView } from 'react-native-gesture-handler';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import { NavigationContainer } from '@react-navigation/native';

const bottomTab = createBottomTabNavigator();

import Home from './main';


export default class Clients extends React.Component {
    state = {
        firstQuery: '',
    };

    render() {
        const { firstQuery } = this.state;

        const Tab = createBottomTabNavigator();

        return (

            <ScrollView
                style={styles.main}
                contentContainerStyle={{ flexGrow: 1, flexDirection: 'column' }}>

                <View style={styles.mainHeader}>
                    <View style={styles.containerAR}>
                        <Pressable style={styles.buttonAdd}>
                            <Text style={styles.text}>adicionar cliente</Text>
                        </Pressable>

                        <Pressable style={styles.buttonRemove}>
                            <Text style={styles.text}>remover cliente</Text>
                        </Pressable>
                    </View>

                    <View style={styles.containerS}>
                        <Searchbar style={styles.searchBar}
                            placeholder=""
                            onChangeText={query => { this.setState({ firstQuery: query }); }}
                            value={firstQuery} />
                    </View>
                </View>

                <View style={styles.vector}>
                    <Image source={require('../assets/vector-original.png')} />
                </View>

                <View style={styles.cards}>
                    <View style={styles.cardClient}>
                        <View style={styles.cardColourG} />
                        <View style={styles.mainInfoCard}>
                            <Text style={styles.key}>nome do cliente</Text>
                            <Text style={styles.keyPhone}>+55 1198975-0185</Text>
                            <View style={styles.clientInfo_}>
                                <Text style={styles.keyR$}>R$</Text>

                                <Pressable style={styles.button}>
                                    <Text style={styles.text}>mandar mensagem</Text>
                                </Pressable>
                            </View>
                        </View>
                    </View>

                    <View style={styles.cardClient}>
                        <View style={styles.cardColourR} />
                        <View style={styles.mainInfoCard}>
                            <Text style={styles.key}>nome do cliente</Text>
                            <Text style={styles.keyPhone}>+55 1198975-0185</Text>
                            <View style={styles.clientInfo_}>
                                <Text style={styles.keyR$}>R$</Text>
                                <Pressable style={styles.button}>
                                    <Text style={styles.text}>mandar mensagem</Text>
                                </Pressable>
                            </View>
                        </View>
                    </View>

                    <View style={styles.cardClient}>
                        <View style={styles.cardColourY} />
                        <View style={styles.mainInfoCard}>
                            <Text style={styles.key}>nome do cliente</Text>
                            <Text style={styles.keyPhone}>+55 1198975-0185</Text>
                            <View style={styles.clientInfo_}>
                                <Text style={styles.keyR$}>R$</Text>
                                <Pressable style={styles.button}>
                                    <Text style={styles.text}>mandar mensagem</Text>
                                </Pressable>
                            </View>
                        </View>
                    </View>
                </View>

                <View style={styles.navBar}>
                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Main')}>
                        <Image source={require('../assets/Home.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Settings')}>
                        <Image source={require('../assets/Settings.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('')}>
                        <Image source={require('../assets/Chart.png')} />
                    </TouchableOpacity>

                    <TouchableOpacity
                        onPress={() => this.props.navigation.navigate('Clients')}>
                        <Image source={require('../assets/Client.png')} />
                    </TouchableOpacity>
                </View>
            </ScrollView>
        );
    }
}

const styles = StyleSheet.create({
    main: {
        flex: 1,
        backgroundColor: '#F4F4F4',
    },

    navBar: {
        width: 360,
        height: 60,
        backgroundColor: '#222222',
        borderRadius: 20,
        flexDirection: 'row',
        alignSelf: 'center',
        alignItems: 'center',
        justifyContent: 'space-around',
        bottom: 0,
    },

    navBarIcons: {
        width: 40,
        height: 40,
        marginLeft: 15,
        marginRight: 15,
        alignSelf: 'center',
    },
    navBarIcons2: {
        width: 40,
        height: 40,
        marginLeft: 15,
        marginRight: 15,
        alignSelf: 'center',
    },

    searchBar: {
        width: 370,
        height: 40,
        borderRadius: 18,
        borderWidth: 2,
        borderColor: '#222222',
        fontSize: 14,
        backgroundColor: '#F4F4F4',
    },

    containerAR: {
        width: 370,
        flexDirection: 'row',
        justifyContent: 'space-between',
        marginTop: 25,
    },

    containerS: {
        width: 370,
        flexDirection: 'row',
        justifyContent: 'space-between',
        marginTop: 25,
    },

    buttonAdd: {
        width: 165,
        height: 40,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        backgroundColor: '#90C9E3',
    },

    buttonRemove: {
        width: 165,
        height: 40,
        alignItems: 'center',
        justifyContent: 'center',
        borderRadius: 20,
        backgroundColor: '#222222',
    },

    vector: {
        position: 'absolute',
        height: 'auto',
        width: 'auto',
        flexDirection: 'column',
        marginTop: 30,
        justifyContent: 'center',
        alignItems: 'center',
        height: '100%',
    },

    button: {
        width: 150,
        height: 30,
        alignItems: 'center',
        justifyContent: 'center',
        borderColor: '#f4f4f4',
        borderWidth: 2,
        borderRadius: 18,
        backgroundColor: 'transparent',
    },

    text: {
        fontSize: 12,
        fontWeight: '700',
        color: 'white',
        textTransform: 'uppercase',
    },

    mainHeader: {
        justifyContent: 'center',
        alignItems: 'center'
    },

    cards: {
        justifyContent: 'center',
        alignItems: 'center',
        marginTop: 25,
    },

    cardClient: {
        width: 360,
        height: 140,
        backgroundColor: "#363636",
        flexDirection: 'row',
        alignItems: 'center',
        borderRadius: 30,
        marginBottom: 15,
    },

    cardColourG: {
        width: 30,
        height: 140,
        backgroundColor: '#97D5BD',
        borderBottomLeftRadius: 30,
        borderTopLeftRadius: 30,
    },

    cardColourY: {
        width: 30,
        height: 140,
        backgroundColor: '#FCE580',
        borderBottomLeftRadius: 30,
        borderTopLeftRadius: 30,
    },

    cardColourR: {
        width: 30,
        height: 140,
        backgroundColor: '#F18184',
        borderBottomLeftRadius: 30,
        borderTopLeftRadius: 30,
    },

    mainInfoCard: {
        flexDirection: "column",
        marginLeft: 15,
        width: '83%',
    },

    key: {
        color: "#fff",
        fontSize: 20,
        marginBottom: 5,
        textTransform: 'uppercase'
    },

    keyPhone: {
        color: "#fff",
        fontSize: 13,
    },

    keyR$: {
        color: "#fff",
        fontSize: 15,
    },

    clientInfo_: {
        flexDirection: "row",
        marginTop: 40,
        justifyContent: 'space-between',
        alignItems: 'center',
    },
});
